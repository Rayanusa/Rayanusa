using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ryn.Services.Customers;
using Ryn.Services.Orders;
using Ryn.Services.Security;
using Ryn.Web.Areas.Admin.Factories;
using Ryn.Web.Areas.Admin.Models.ShoppingCart;
using Ryn.Web.Framework.Mvc;

namespace Ryn.Web.Areas.Admin.Controllers
{
    public partial class ShoppingCartController : BaseAdminController
    {
        #region Fields

        private readonly ICustomerService _customerService;
        private readonly IPermissionService _permissionService;
        private readonly IShoppingCartModelFactory _shoppingCartModelFactory;
        private readonly IShoppingCartService _shoppingCartService;
        #endregion

        #region Ctor

        public ShoppingCartController(ICustomerService customerService,
            IPermissionService permissionService,
            IShoppingCartService shoppingCartService,
            IShoppingCartModelFactory shoppingCartModelFactory)
        {
            _customerService = customerService;
            _permissionService = permissionService;
            _shoppingCartModelFactory = shoppingCartModelFactory;
            _shoppingCartService = shoppingCartService;
        }

        #endregion
        
        #region Methods
        
        public virtual async Task<IActionResult> CurrentCarts()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCurrentCarts))
                return AccessDeniedView();

            //prepare model
            var model = await _shoppingCartModelFactory.PrepareShoppingCartSearchModelAsync(new ShoppingCartSearchModel());

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> CurrentCarts(ShoppingCartSearchModel searchModel)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCurrentCarts))
                return await AccessDeniedDataTablesJson();

            //prepare model
            var model = await _shoppingCartModelFactory.PrepareShoppingCartListModelAsync(searchModel);

            return Json(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> GetCartDetails(ShoppingCartItemSearchModel searchModel)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCurrentCarts))
                return await AccessDeniedDataTablesJson();

            //try to get a customer with the specified id
            var customer = await _customerService.GetCustomerByIdAsync(searchModel.CustomerId)
                ?? throw new ArgumentException("No customer found with the specified id");

            //prepare model
            var model = await _shoppingCartModelFactory.PrepareShoppingCartItemListModelAsync(searchModel, customer);

            return Json(model);
        }
        
        [HttpPost]
        public virtual async Task<IActionResult> DeleteItem(int id)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageCurrentCarts))
                return await AccessDeniedDataTablesJson();
            
            await _shoppingCartService.DeleteShoppingCartItemAsync(id);

            return new NullJsonResult();
        }

        #endregion
    }
}