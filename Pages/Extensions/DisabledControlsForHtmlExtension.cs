﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Homework4.Pages.Extensions
{
    public static class DisabledControlsForHtmlExtension
    {
        public static IHtmlContent DisabledControlsFor<TModel, TResult>
            (this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression)
        {
            var s = htmlString(htmlHelper, expression);

            return new HtmlContentBuilder(s);
        }

        internal static List<object> htmlString<TModel, TResult>(
            IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression)
        {
            return new List<object>
            {
                new HtmlString("<div class = \"form-group\">"),
                new HtmlString("<fieldset disabled>"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.EditorFor(expression, new {htmlAttributes = new {@class = "form-control"}}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</fieldset>"),
                new HtmlString("</div>")
            };
        }
    }
}