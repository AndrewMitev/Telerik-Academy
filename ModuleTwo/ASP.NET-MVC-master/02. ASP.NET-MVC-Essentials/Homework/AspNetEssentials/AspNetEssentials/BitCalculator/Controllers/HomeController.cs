namespace BitCalculator.Controllers
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using System;

    public class HomeController : Controller
    {
        private IEnumerable<SelectListItem> data = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "bit - b",        Value = "b" },
            new SelectListItem() { Text = "Byte - B",       Value = "B" },
            new SelectListItem() { Text = "Kilobyte - KB",  Value = "KB" },
            new SelectListItem() { Text = "Megabit - Mb",   Value = "Mb" },
            new SelectListItem() { Text = "Megabyte - MB",  Value = "MB" },
            new SelectListItem() { Text = "Gigabit - Gb",   Value = "Gb" },
            new SelectListItem() { Text = "Gigabyte - GB",  Value = "GB" },
            new SelectListItem() { Text = "Terabit - Tb",   Value = "Tb" },
            new SelectListItem() { Text = "Terabyte - TB",  Value = "TB" },
            new SelectListItem() { Text = "Petabit - Pb",   Value = "Pb" },
            new SelectListItem() { Text = "Petabyte - PB",  Value = "PB" },
            new SelectListItem() { Text = "Exabit - Eb",    Value = "Eb" },
            new SelectListItem() { Text = "Exabyte - EB",   Value = "EB" },
            new SelectListItem() { Text = "Zettabit - Zb",  Value = "Zb" },
            new SelectListItem() { Text = "Zettabyte - ZB", Value = "ZB" },
            new SelectListItem() { Text = "Yottabit - Yb",  Value = "Yb" },
            new SelectListItem() { Text = "Yottabyte - YB", Value = "YB" },

        };

        public ActionResult Index()
        {
            var model = new Data();

            model.data = this.data;

            return View(model);
        }

        public ActionResult Calculate(Data data)
        {
            var listA = new System.Collections.Generic.List<Helper>()
            {
                new Helper() { Name = "b"},
                new Helper() { Name = "Kb"},
                new Helper() { Name = "Mb"},
                new Helper() { Name = "Gb"},
                new Helper() { Name = "Tb"},
                new Helper() { Name = "Pb"},
                new Helper() { Name = "Eb"},
                new Helper() { Name = "Zb"},
                new Helper() { Name = "Yb"},
            };

            var listB = new System.Collections.Generic.List<Helper>()
            {
                new Helper() { Name = "B"},
                new Helper() { Name = "KB"},
                new Helper() { Name = "MB"},
                new Helper() { Name = "GB"},
                new Helper() { Name = "TB"},
                new Helper() { Name = "PB"},
                new Helper() { Name = "EB"},
                new Helper() { Name = "ZB"},
                new Helper() { Name = "YB"},
            };

            char caseIndicator = data.Type.Length == 1 ? data.Type[0] : data.Type[1];

            var rawData = this.UpdateValues(caseIndicator, listA, listB, data);

            return View("Index", new Data() { data = this.data, dataToDisplay = rawData });
        }

        public ICollection<Helper> UpdateValues(char caseIndicator, List<Helper> listA, List<Helper> listB, Data data)
        {
            var listToLookInto = caseIndicator == 'b' ? listA : listB;

            var entityToUpdate = listToLookInto.FirstOrDefault(x => x.Name == data.Type);
            entityToUpdate.Value = 1 * data.Quantity;
            int index = listToLookInto.IndexOf(entityToUpdate);


            if (caseIndicator == 'b')
            {
                listB[index].Value = entityToUpdate.Value / 8;
            }
            else if (caseIndicator == 'B')
            {
                listA[index].Value = entityToUpdate.Value * 8;
            }

            if (index == 0)
            {
                for (int i = 1; i < listA.Count(); i++)
                {
                    listA[i].Value = (data.Quantity * listA[i - 1].Value) / data.Base;
                    listB[i].Value = (data.Quantity * listB[i - 1].Value) / data.Base;
                }

                var allTypes = CustomMerge(listA, listB);

                return allTypes;
            }

            if (index == listA.Count())
            {
                for (int i = index - 1; i == 0; i--)
                {
                    listA[i].Value = (data.Quantity * listA[i + 1].Value) * data.Base;
                    listB[i].Value = (data.Quantity * listB[i + 1].Value) * data.Base;
                }

                var allTypes = CustomMerge(listA,listB);

                return allTypes;
            }

            for (int i = index + 1; i < listA.Count(); i++)
            {
                listA[i].Value = (data.Quantity * listA[i - 1].Value) / data.Base;
                listB[i].Value = (data.Quantity * listB[i - 1].Value) / data.Base;
            }

            for (int i = index - 1; i >= 0; i--)
            {
                listA[i].Value = (data.Quantity * listA[i + 1].Value) * data.Base;
                listB[i].Value = (data.Quantity * listB[i + 1].Value) * data.Base;
            }

            var merged = CustomMerge(listA, listB);

            return merged;
        }

        private List<Helper> CustomMerge(List<Helper> listA, List<Helper> listB)
        {
            var merged = new List<Helper>();

            for (int i = 0; i < listA.Count; i++)
            {
                merged.Add(listA[i]);
                merged.Add(listB[i]);
            }

            return merged;
        }
    }
}