﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web.HtmlExtensions
{
	    public static class HtmlHelperExtensions
    {
        #region DropDownListFor Extensions

        public static IHtmlContent DropDownListUtilityFor<TModel, TProperty>(this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, SelectList selectList, SelectListItem optionalSelectItem, object htmlAttributes)
        {
            if (htmlHelper == null) throw new ArgumentNullException("htmlHelper");
            if (expression == null) throw new ArgumentNullException("expression");

            return htmlHelper.DropDownListFor(expression, SelectListItemUtility(selectList, optionalSelectItem), htmlAttributes);
        }

        public static IHtmlContent DropDownListUtility(this IHtmlHelper htmlHelper, string name, SelectList selectList, SelectListItem optionalSelectItem, object htmlAttributes)
        {
            if (htmlHelper == null) throw new ArgumentNullException("htmlHelper");

            return htmlHelper.DropDownList(name, SelectListItemUtility(selectList, optionalSelectItem), htmlAttributes);
        }

        private static List<SelectListItem> SelectListItemUtility(SelectList selectList, SelectListItem optionalSelectItem)
        {
            if (selectList != null)
            {
                if (optionalSelectItem != null)
                {
                    List<SelectListItem> optionSelectList = new List<SelectListItem> {optionalSelectItem};
                    foreach (SelectListItem selectListItem in selectList)
                    {
                        if (optionalSelectItem.Value == selectListItem.Value)
                        {
                            optionSelectList.RemoveAt(0);
                        }
                        optionSelectList.Add(selectListItem);
                    }
                    return optionSelectList;
                }
                return selectList.ToList();
            }
            if (optionalSelectItem != null)
            {
                return new List<SelectListItem> {optionalSelectItem};
            }
            return new List<SelectListItem> {new SelectListItem {Text = ""}};
        }
        
        /*add customized code between this region*/
        /*add customized code between this region*/
        #endregion
    }
}