using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Pages
    {
        private int m_nNumberOfPages;
        private string[] m_sPageNames = 
        {
            "Electricity",
            "Hot Water",
            "Heating",
            "Current Usage",
            "Bill Status",
            "Monitor",
            "Weather",
            "Security",
            "Settings",
            "Home"
        };
        public Pages(int numberOfPages = 9)
        {
            m_nNumberOfPages = numberOfPages;
        }
        public virtual string PageNameCallback( int index = 8 ) // by default it will go to the main display
        {
            return m_sPageNames[index];
        }
    }
    class Bill
    {
        private float m_fCurrentBillPounds;
        private float m_fCurrentBillkWh;
        public Bill()
        {
            m_fCurrentBillPounds = 110.83F;
            m_fCurrentBillkWh = 13.150F;
        }
        public string DisplayBillInPounds()
        {
            return m_fCurrentBillPounds.ToString();
        }
        public string DisplayBillInkWh()
        {
            return m_fCurrentBillkWh.ToString();
        }
        public float percentageResultFLOAT( int percenatage )
        {
            float temp = (float)percenatage;
            temp = temp / 10;
            temp *= m_fCurrentBillPounds;
            return temp;
        }
        public String percentageResultSTRING(int percentages)
        {
            float temp = (float)percentages;
            temp = temp / 100;
            temp *= m_fCurrentBillPounds;
            return temp.ToString();
        }
    }
}
