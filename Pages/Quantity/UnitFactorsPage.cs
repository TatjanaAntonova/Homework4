﻿using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;

namespace Homework4.Pages.Quantity
{
    public class UnitFactorsPage : CommonPage<IUnitFactorsRepository, UnitFactor, UnitFactorView, UnitFactorData>
    {
        protected internal UnitFactorsPage(IUnitFactorsRepository r = null) : base(r)
        {
            PageTitle = "Unit Factors";
        }

        public override string ItemId
        {
            get
            {
                if (Item is null) return string.Empty;
                return $"{Item.SystemOfUnitsId}.{Item.UnitId}";
            }
        }


        protected internal override string getPageUrl() => "/Quantity/UnitFactors";

        protected internal override UnitFactor toObject(UnitFactorView view)
        {
            return UnitFactorViewFactory.Create(view);
        }

        protected internal override UnitFactorView toView(UnitFactor obj)
        {
            return UnitFactorViewFactory.Create(obj);
        }
    }
}


