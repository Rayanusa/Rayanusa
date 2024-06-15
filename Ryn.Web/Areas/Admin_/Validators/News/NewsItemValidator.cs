﻿using FluentValidation;
using Ryn.Core.Domain.News;
using Ryn.Data.Mapping;
using Ryn.Services.Localization;
using Ryn.Services.Seo;
using Ryn.Web.Areas.Admin.Models.News;
using Ryn.Web.Framework.Validators;

namespace Ryn.Web.Areas.Admin.Validators.News
{
    public partial class NewsItemValidator : BaseRynValidator<NewsItemModel>
    {
        public NewsItemValidator(ILocalizationService localizationService, IMappingEntityAccessor mappingEntityAccessor)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.News.NewsItems.Fields.Title.Required"));

            RuleFor(x => x.Short).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.News.NewsItems.Fields.Short.Required"));

            RuleFor(x => x.Full).NotEmpty().WithMessageAwait(localizationService.GetResourceAsync("Admin.ContentManagement.News.NewsItems.Fields.Full.Required"));

            RuleFor(x => x.SeName).Length(0, NopSeoDefaults.SearchEngineNameLength)
                .WithMessageAwait(localizationService.GetResourceAsync("Admin.SEO.SeName.MaxLengthValidation"), NopSeoDefaults.SearchEngineNameLength);

            SetDatabaseValidationRules<NewsItem>(mappingEntityAccessor);
        }
    }
}