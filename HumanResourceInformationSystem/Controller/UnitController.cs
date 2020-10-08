﻿using HumanResourceInformationSystem.Adapter;
using HumanResourceInformationSystem.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceInformationSystem.Controller
{
    class UnitController
    {
        private static List<Unit> Units;
        private static List<Class> Classes;
        public static Unit Unit { set; get; }
        public static List<Unit> filterUnitByString(string s)
        {
            checkUnits();
            List<Unit> r = new List<Unit>();
            // linQ
            var list = Units.Where(u => isStringContain(u.Code, s) || isStringContain(u.Title, s)).Select(u => u);
            foreach (Unit u in list)
            {
                r.Add(u);
            }
            return r;
        }

        public static List<Unit> getUnitList()
        {
            checkUnits();
            return Units;
        }

        public static List<Class> getClassListByUnit(Unit unit)
        {
            Classes = DatabaseAdapter.RetrieveClassesByUnit(unit);
            return Classes;
        }


        private static void checkUnits()
        {
            if (Units == null)
                Units = DatabaseAdapter.RetrieveUnits();
        }

        private static bool isStringContain(string source, string target)
        {
            return source.IndexOf(target, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
