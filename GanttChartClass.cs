using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace ProjectManagementPro
{
    class GanttChartClass
    {

        bool boolLeapYear;

        int intYear;

        string strStartDayForCalendar;

        DateTime newDateTime;

        List<string> Months = new List<string>();
        List<string> Days = new List<string>();
        List<string> DayNumbers = new List<string>();

        List<Color> barColorsList = new List<Color>();

        FileIOClass newFileIO = new FileIOClass();

        public GanttChartClass()
        {

            boolLeapYear = IsLeapYear();

            LoadCalendarDays();

        }
         // *** Boolean ***
        private bool IsLeapYear()
        {
            // Checks the date to see if it is a leap year

            string strDate = DateTime.Today.ToString("yyyy");

            intYear = Int32.Parse(strDate);

            bool boolYear = DateTime.IsLeapYear(intYear);

            return boolYear;

        }

        // *** Integers ***
        public int GetDaysInTheMonth(int month)
        {
            // Returns the number of days in the month

            int numDays = 0;

            switch (month)
            {

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    numDays = 31;

                    break;

                case 4:
                case 6:
                case 9:
                case 11:

                    numDays = 30;

                    break;

                case 2:

                    if (boolLeapYear)
                    {

                        numDays = 29;

                    }
                    else
                    {

                        numDays = 28;

                    }

                    break;


            }

            return numDays;

        }

        private int GetDayNumberForCalendar(string strDay)
        {
            // Returns the day number 

            string day = strDay.ToUpper();

            int intDayNum = 0;

            switch (day)
            {

                case "MON":

                    intDayNum = 1;

                    break;

                case "TUE":

                    intDayNum = 2;

                    break;

                case "WED":

                    intDayNum = 3;

                    break;

                case "THU":

                    intDayNum = 4;

                    break;

                case "FRI":

                    intDayNum = 5;

                    break;

                case "SAT":

                    intDayNum = 6;

                    break;

                case "SUN":

                    intDayNum = 7;

                    break;

            }

            return intDayNum;

        }

        // *** Strings ***
      
        private string GetDayOfWeekForCalendar(int day)
        {
            // Returns the three char code for the day

            string strDay = "";

            switch (day)
            {

                case 1:

                    strDay = "Mon";

                    break;

                case 2:

                    strDay = "Tue";

                    break;

                case 3:

                    strDay = "Wed";

                    break;

                case 4:

                    strDay = "Thu";

                    break;

                case 5:

                    strDay = "Fri";

                    break;

                case 6:

                    strDay = "Sat";

                    break;

                case 7:

                    strDay = "Sun";

                    break;

            }

            return strDay;

        }
        
        private string GetMonth(int intMonth)
        {
            // Gets the name of the month

            string strMonth = "";

            switch (intMonth)
            {

                case 1:

                    strMonth = "JAN";

                    break;

                case 2:

                    strMonth = "FEB";

                    break;

                case 3:

                    strMonth = "MAR";

                    break;

                case 4:

                    strMonth = "APR";

                    break;

                case 5:

                    strMonth = "MAY";

                    break;

                case 6:

                    strMonth = "JUN";

                    break;

                case 7:

                    strMonth = "JUL";

                    break;

                case 8:

                    strMonth = "AUG";

                    break;

                case 9:

                    strMonth = "SEP";

                    break;

                case 10:

                    strMonth = "OCT";

                    break;

                case 11:

                    strMonth = "NOV";

                    break;

                case 12:

                    strMonth = "DEC";

                    break;

            }

            return strMonth;

        }
        private string GetStartDayForCalendar()
        {
            // Gets the name of the day for January 1st                                            

            int year = Int32.Parse(DateTime.Now.Year.ToString());

            newDateTime = new DateTime(year, 1, 1);

            strStartDayForCalendar = newDateTime.ToString("ddd");

            return strStartDayForCalendar;

        }

        public string GetMonthForProgressBar(DateTime date)
        { 
            // Returns the selected month from the specified date

            int intMonth = date.Month;

            string strMonthName = GetMonth(intMonth).ToUpper();

            return strMonthName;

        }

        public string GetDayForProgressBar(DateTime date)
        {
            // Returns the day from the specified date

            int intDay = date.Day;

            string strDay = intDay.ToString();

            return strDay;

        }

        // *** Lists ***

        public List<Color> GetProgressBarColors()
        {
            // Gets a list of colors for the project progress bars
                       
            List<Color> progressBarColorList = GetBarColors();

            return progressBarColorList;

        }

        public List<Color> GetBarColors()
        {
            // Returns a list of selected bar colors

            string strFileName = newFileIO.GetPathToGanttChartBarColorSetupFile();

            //if (File.Exists(strFileName))
            try
            {

                XmlDocument newXMLDocument = new XmlDocument();

                newXMLDocument.Load(strFileName);

                XmlNodeList BarColorList = newXMLDocument.GetElementsByTagName("Color");

                string strNameOfControl = "";

                string strColorName = "";

                int i = 0;

                foreach (XmlNode node in BarColorList)
                {

                    strColorName = node.InnerText; // .SelectSingleNode("Color").InnerText;  //SelectSingleNode(strNameOfControl).InnerText;

                    barColorsList.Add(Color.FromArgb(int.Parse(strColorName)));

                    i++;

                }


            }
            catch (IOException)
            {

                // MessageBox.Show("Bar color file not found. Default colors will be used instead.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // Load default colors if bar color list is empty
            if (barColorsList.Count < 1)
            {
                barColorsList = new List<Color>();

                barColorsList.Add(Color.Blue);
                barColorsList.Add(Color.Lime);
                barColorsList.Add(Color.Fuchsia);
                barColorsList.Add(Color.Aqua);
                barColorsList.Add(Color.Yellow);
                barColorsList.Add(Color.Brown);
                barColorsList.Add(Color.Magenta);
                barColorsList.Add(Color.Turquoise);

            }

            return barColorsList;

        }
        public List<string> GetMonths()
        {

            return Months;

        }

        public List<string> GetDays()
        {

            return Days;

        }

        public List<string> GetDayNumbers()
        {

            return DayNumbers;

        }

        public List<string> GetGanttChartColumnNames()
        {
            // Gets the column names for the Gantt chart datagrid

            List<string> names = new List<string>();

            names.Add("Project Number");
            names.Add("Project Name");
            names.Add("Project Phase");
            names.Add("Project Status");
            names.Add("Start Date");
            names.Add("Projected Completion");
            //names.Add("Actual");

            for (int i = 0; i < DayNumbers.Count; i++)
            {

                names.Add(Months[i].ToString() + Environment.NewLine + Days[i].ToString() + Environment.NewLine + DayNumbers[i].ToString());

            }

            return names;

        }
               
      
       

        // *** Void Procedures ***
        private void LoadCalendarDays()
        {
            // Gets the data for the calendar

            string currentDay = "";

            string firstDay = GetStartDayForCalendar(); // First day for the calendar

            int intDayNum = GetDayNumberForCalendar(firstDay);

            string strDayNumber = "";

            for (int i = 1; i < 13; i++) // Months
            {

                int daysInMonth = GetDaysInTheMonth(i);

                string month = GetMonth(i);

                for (int j = 0; j < daysInMonth; j++) // Days
                {

                    Months.Add(month);

                    currentDay = GetDayOfWeekForCalendar(intDayNum);

                    Days.Add(currentDay);

                    strDayNumber = (j + 1).ToString();

                    DayNumbers.Add(strDayNumber);

                    if (intDayNum < 7)
                    {

                        intDayNum++;

                    }
                    else
                    {
                        intDayNum = 1;

                    }

                }

            }

        }


        public void WriteTimelineBarColorsToFile(List<int> listOfBarColors)
        {
            // Writes the timeline bar colors to file

            string strFileName = newFileIO.GetPathToGanttChartBarColorSetupFile();

            // Create a new file if one exists
            if (File.Exists(strFileName))
            {

                File.Delete(strFileName);

            }

            try
            {

                XmlWriter writer = XmlWriter.Create(strFileName);

                writer.WriteStartDocument();

                writer.WriteStartElement("BarColors");

                writer.WriteStartElement("Colors");

                for (int i = 0; i < listOfBarColors.Count; i++)
                {

                    writer.WriteElementString("Color", listOfBarColors[i].ToString());

                }

                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Close();

            }
            catch (IOException ex)
            {

                MessageBox.Show("Save operation failed.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}