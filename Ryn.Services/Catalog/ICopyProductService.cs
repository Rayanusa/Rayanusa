﻿using System.Threading.Tasks;
using Ryn.Core.Domain.Catalog;

namespace Ryn.Services.Catalog
{
    /// <summary>
    /// Copy product service
    /// </summary>
    public partial interface ICopyProductService
    {
        /// <summary>
        /// Create a copy of product with all depended data
        /// </summary>
        /// <param name="product">The product to copy</param>
        /// <param name="newName">The name of product duplicate</param>
        /// <param name="isPublished">A value indicating whether the product duplicate should be published</param>
        /// <param name="copyImages">A value indicating whether the product images should be copied</param>
        /// <param name="copyAssociatedProducts">A value indicating whether the copy associated products</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the product copy
        /// </returns>
        Task<Product> CopyProductAsync(Product product, string newName,
            bool isPublished = true, bool copyImages = true, bool copyAssociatedProducts = true);
    }
}