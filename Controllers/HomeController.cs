using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefectMap.Models;

namespace DefectMap.Controllers
{
    public class HomeController : Controller
    {

        protected List<PanelConfig> GeneratePanelConfig(int xPanelCount, int yPanelCount, int glassWidth, int glassHeight, int margin, int padding)
        {
            List<PanelConfig> panelConfigs = new List<PanelConfig>();
            int panelWidth = ((glassWidth - 2 * margin ) - (xPanelCount - 1) * padding) / xPanelCount;
            int panelHeight = ((glassHeight - 2 * margin ) - (yPanelCount - 1) * padding) / yPanelCount;
            int idNumber = 1;
            for (int i = 0; i < xPanelCount; i++)
            {
                for (int j = 0; j <　yPanelCount; j++)
                {
                    panelConfigs.Add( new PanelConfig()
                        {
                            X = margin + i * (panelWidth + padding),
                            Y = margin + j * (panelHeight + padding),
                            Height = panelHeight,
                            Width = panelWidth,
                            ID = idNumber.ToString("000")
                        });
                    idNumber++;
                }
            }
            return panelConfigs;
        }

        protected LayoutConfig GenerateLayoutConfig()
        {
            return new LayoutConfig()
            {
                Width = 1100,
                Height = 1300,
                ChipCorner = Corner.RightBottom,
                Panles = GeneratePanelConfig(3, 4, 1100, 1300, 50, 50)
            };
            
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.LayoutCOnfig = GenerateLayoutConfig();
            return View();
        }

    }
}
