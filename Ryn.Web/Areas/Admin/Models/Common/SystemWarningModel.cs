using Ryn.Web.Framework.Models;

namespace Ryn.Web.Areas.Admin.Models.Common
{
    public partial record SystemWarningModel : BaseRynModel
    {
        public SystemWarningLevel Level { get; set; }

        public string Text { get; set; }

        public bool DontEncode { get; set; }
    }
}