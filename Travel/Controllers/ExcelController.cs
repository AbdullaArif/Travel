using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;

namespace Travel.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public List<DestinationViewModel> DestinationList()
        {
            List<DestinationViewModel> destinationViewModels = new List<DestinationViewModel>();
            using (var c = new Context())
            {
                destinationViewModels = c.Destinations.Select(x => new DestinationViewModel
                {
                    City = x.City,
                    Date = x.Date,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationViewModels;
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Destination List");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "Date";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 4).Value = "Capacity";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.Date;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewList.xlsx");
                 }

            }

        }
    }
}
