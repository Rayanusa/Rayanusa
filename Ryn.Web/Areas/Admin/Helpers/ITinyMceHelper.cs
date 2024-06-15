using System.Threading.Tasks;

namespace Ryn.Web.Areas.Admin.Helpers
{
    public interface ITinyMceHelper
    {
        Task<string> GetTinyMceLanguageAsync();
    }
}