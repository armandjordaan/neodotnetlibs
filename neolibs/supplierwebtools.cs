/*
                    GNU LESSER GENERAL PUBLIC LICENSE
                       Version 3, 29 June 2007

 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.


  This version of the GNU Lesser General Public License incorporates
the terms and conditions of version 3 of the GNU General Public
License, supplemented by the additional permissions listed below.

  0. Additional Definitions.

  As used herein, "this License" refers to version 3 of the GNU Lesser
General Public License, and the "GNU GPL" refers to version 3 of the GNU
General Public License.

  "The Library" refers to a covered work governed by this License,
other than an Application or a Combined Work as defined below.

  An "Application" is any work that makes use of an interface provided
by the Library, but which is not otherwise based on the Library.
Defining a subclass of a class defined by the Library is deemed a mode
of using an interface provided by the Library.

  A "Combined Work" is a work produced by combining or linking an
Application with the Library.  The particular version of the Library
with which the Combined Work was made is also called the "Linked
Version".

  The "Minimal Corresponding Source" for a Combined Work means the
Corresponding Source for the Combined Work, excluding any source code
for portions of the Combined Work that, considered in isolation, are
based on the Application, and not on the Linked Version.

  The "Corresponding Application Code" for a Combined Work means the
object code and/or source code for the Application, including any data
and utility programs needed for reproducing the Combined Work from the
Application, but excluding the System Libraries of the Combined Work.

  1. Exception to Section 3 of the GNU GPL.

  You may convey a covered work under sections 3 and 4 of this License
without being bound by section 3 of the GNU GPL.

  2. Conveying Modified Versions.

  If you modify a copy of the Library, and, in your modifications, a
facility refers to a function or data to be supplied by an Application
that uses the facility (other than as an argument passed when the
facility is invoked), then you may convey a copy of the modified
version:

   a) under this License, provided that you make a good faith effort to
   ensure that, in the event an Application does not supply the
   function or data, the facility still operates, and performs
   whatever part of its purpose remains meaningful, or

   b) under the GNU GPL, with none of the additional permissions of
   this License applicable to that copy.

  3. Object Code Incorporating Material from Library Header Files.

  The object code form of an Application may incorporate material from
a header file that is part of the Library.  You may convey such object
code under terms of your choice, provided that, if the incorporated
material is not limited to numerical parameters, data structure
layouts and accessors, or small macros, inline functions and templates
(ten or fewer lines in length), you do both of the following:

   a) Give prominent notice with each copy of the object code that the
   Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the object code with a copy of the GNU GPL and this license
   document.

  4. Combined Works.

  You may convey a Combined Work under terms of your choice that,
taken together, effectively do not restrict modification of the
portions of the Library contained in the Combined Work and reverse
engineering for debugging such modifications, if you also do each of
the following:

   a) Give prominent notice with each copy of the Combined Work that
   the Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the Combined Work with a copy of the GNU GPL and this license
   document.

   c) For a Combined Work that displays copyright notices during
   execution, include the copyright notice for the Library among
   these notices, as well as a reference directing the user to the
   copies of the GNU GPL and this license document.

   d) Do one of the following:

       0) Convey the Minimal Corresponding Source under the terms of this
       License, and the Corresponding Application Code in a form
       suitable for, and under terms that permit, the user to
       recombine or relink the Application with a modified version of
       the Linked Version to produce a modified Combined Work, in the
       manner specified by section 6 of the GNU GPL for conveying
       Corresponding Source.

       1) Use a suitable shared library mechanism for linking with the
       Library.  A suitable mechanism is one that (a) uses at run time
       a copy of the Library already present on the user's computer
       system, and (b) will operate properly with a modified version
       of the Library that is interface-compatible with the Linked
       Version.

   e) Provide Installation Information, but only if you would otherwise
   be required to provide such information under section 6 of the
   GNU GPL, and only to the extent that such information is
   necessary to install and execute a modified version of the
   Combined Work produced by recombining or relinking the
   Application with a modified version of the Linked Version. (If
   you use option 4d0, the Installation Information must accompany
   the Minimal Corresponding Source and Corresponding Application
   Code. If you use option 4d1, you must provide the Installation
   Information in the manner specified by section 6 of the GNU GPL
   for conveying Corresponding Source.)

  5. Combined Libraries.

  You may place library facilities that are a work based on the
Library side by side in a single library together with other library
facilities that are not Applications and are not covered by this
License, and convey such a combined library under terms of your
choice, if you do both of the following:

   a) Accompany the combined library with a copy of the same work based
   on the Library, uncombined with any other library facilities,
   conveyed under the terms of this License.

   b) Give prominent notice with the combined library that part of it
   is a work based on the Library, and explaining where to find the
   accompanying uncombined form of the same work.

  6. Revised Versions of the GNU Lesser General Public License.

  The Free Software Foundation may publish revised and/or new versions
of the GNU Lesser General Public License from time to time. Such new
versions will be similar in spirit to the present version, but may
differ in detail to address new problems or concerns.

  Each version is given a distinguishing version number. If the
Library as you received it specifies that a certain numbered version
of the GNU Lesser General Public License "or any later version"
applies to it, you have the option of following the terms and
conditions either of that published version or of any later version
published by the Free Software Foundation. If the Library as you
received it does not specify a version number of the GNU Lesser
General Public License, you may choose any version of the GNU Lesser
General Public License ever published by the Free Software Foundation.

  If the Library as you received it specifies that a proxy can decide
whether future versions of the GNU Lesser General Public License shall
apply, that proxy's public statement of acceptance of any version is
permanent authorization for you to choose that version for the
Library.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using neolibs;
using System.Web;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace neolibs.Supplier
{
    /// <summary>
    /// Pricing information on an item
    /// </summary>
    public struct PricingInfo 
    {
        /// <summary>
        /// Flag to indicate that web pricing is not available - supplier has given instructions to call 
        /// for pricing
        /// </summary>
        public bool CallForPricing;

        /// <summary>
        /// Source cost value
        /// </summary>
        public double SrcCost;

        /// <summary>
        /// Dest cost
        /// </summary>
        public double DestCost;

        /// <summary>
        /// Source Currency
        /// </summary>
        public string srcCurr;

        /// <summary>
        /// Dest Currency
        /// </summary>
        public string destCurr;

        /// <summary>
        /// minimum quantity for which this price is valid
        /// </summary>
        public int minqty;

        /// <summary>
        /// maximum quantity for which the price is valid
        /// </summary>
        public int maxqty;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="SrcCurrency">Source currency eg "USD"</param>
        /// <param name="DestCurrency">Source currency eg "ZAR"</param>
        /// <param name="SrcVal">Source Cost value (eg USD value)</param>
        /// <param name="DestVal">Dest Cost value (eg ZAR value)</param>
        /// <param name="min">Minimum for which the price is valid</param>
        /// <param name="max">Maximum for which the price is valid</param>
        public PricingInfo(string SrcCurrency, string DestCurrency, double SrcVal, double DestVal, int min, int max)
        {
            SrcCost  = SrcVal;
            DestCost = DestVal;
            srcCurr  = SrcCurrency;
            destCurr = DestCurrency;
            minqty   = min;
            maxqty   = max;
            CallForPricing = false;
        }

        /// <summary>
        /// Constructor - use when we have to call for pricing (or on request only)
        /// </summary>
        /// <param name="fCallForPricing">Must be set to true, or an exception will be thrown</param>
        public PricingInfo(bool fCallForPricing)
        {
            SrcCost  = 0.0;
            DestCost = 0.0;
            srcCurr  = "ZAR";
            destCurr = "ZAR";
            minqty   = 0;
            maxqty   = 9999999;
            if (fCallForPricing)
            {
                CallForPricing = fCallForPricing;
            }
            else
            {
                throw new Exception("public PricingInfo(bool fCallForPricing) call with parameter false");
            }
        }
    }

    /// <summary>
    /// Base class for SupplierWebTools
    /// </summary>
    public abstract class SupplierWebToolsBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SupplierWebToolsBase()
        {
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~SupplierWebToolsBase()
        {
        }

        string m_webpagedata = "";
        string[] m_webpagelines;
        string m_url = "";
        string m_partnumber = "";
        string m_defDestCurrency = "ZAR";

        /// <summary>
        /// Default destination currency
        /// </summary>
        public string DefDestCurrency
        {
            get {return m_defDestCurrency; }
            set {m_defDestCurrency = value; }
        }

        /// <summary>
        /// Webpage raw data
        /// </summary>
        public string WebPageData
        {
            get { return m_webpagedata; }
            set { m_webpagedata = value; } 
        }

        /// <summary>
        /// WebpageLines = array of lines of html file
        /// </summary>
        public string[] WebPageLines
        {
            get {return m_webpagelines; }
            set {m_webpagelines = value; }
        }

        /// <summary>
        /// Url property
        /// </summary>
        public string Url
        {
            get {return m_url; }
            set {m_url = value;}
        }

        /// <summary>
        /// Partnumber property
        /// </summary>
        public string PartNumber 
        {
            get {return m_partnumber; }
            set {m_partnumber = value;}
        }

        /// <summary>
        /// Single string containing the entire webpage
        /// </summary>
        public string WebPageContent
        {
            get {return m_webpagedata; }
        }

        /// <summary>
        /// Abstract function to build URL from partnumber
        /// </summary>
        /// <param name="pn">partnumber string</param>
        public abstract void BuildUrl(string pn);

        /// <summary>
        /// Load the page data for this supplier
        /// </summary>
        /// <param name="pn"></param>
        /// <param name="ToCurrency">Currency to report the values in</param>
        public void LoadPageData(string pn, string ToCurrency = "ZAR")
        {
            BuildUrl(pn);
            m_defDestCurrency = ToCurrency;
            m_partnumber = pn;
            int retry = 4;
            while(retry > 0)
            {
                retry--;
                try
                {
                    m_webpagedata = WebUtils.DownloadWebPage(Url);
                    retry = 0;
                }
                catch(Exception ex)
                {
                    if (retry <= 0) throw ex;
                }
            }
            m_webpagelines = m_webpagedata.Split(new char[] {'\n'});
        }

        /// <summary>
        /// Get pricing information
        /// </summary>
        /// <returns></returns>
        public abstract PricingInfo[] GetPricingInfo();

        /// <summary>
        /// Abstract method to get string
        /// </summary>
        /// <returns>Manufacturer name</returns>
        public abstract string GetManufacturer();

        /// <summary>
        /// Abstract Get Manufacturer Part number
        /// </summary>
        /// <returns>Manufacturer part number</returns>
        public abstract string GetManufacturerPartNo();
    }

    /// <summary>
    /// Digikey supplier tools
    /// </summary>
    public class DigikeyTools : SupplierWebToolsBase
    {
        /// <summary>
        /// Digikey supplier class constructor
        /// </summary>
        public DigikeyTools() : base()
        {

        }

        /// <summary>
        /// Build URL for Digikey
        /// </summary>
        /// <param name="pn">Partnumber</param>
        public override void BuildUrl(string pn)
        {
            string temp = HttpUtility.UrlEncode(pn);
            Url = @"http://www.digikey.com/scripts/DkSearch/dksus.dll?Detail&name=" + temp;
            // Url = Uri.EscapeUriString(Url);
        }

        /// <summary>
        /// Obtain pricing information from Digikey website
        /// </summary>
        /// <returns></returns>
        public override PricingInfo[] GetPricingInfo()
        {
            try
            {
                int state = 0;
                List<PricingInfo> priceslist = new List<PricingInfo>(50);
                int i;

                for(i=0; (i<WebPageLines.Count()) && (state < 3); i++)
                {
                    string line = WebPageLines[i];
                    switch (state)
                    {
                        case 0: // look for "Price Break" text
                            if (line.Contains("Price Break"))
                            {
                                state = 1;
                            }
                            break;

                        case 1: // skip a line
                            state = 2;
                            break;

                        case 2: // analyse the table
                            if (line.Contains("</table>"))
                            {
                                state = 3;
                            }
                            else
                            {
                                line = line.Replace(",","");
                                line = line.Replace("<tr><td align=center >","");
                                line = line.Replace("</td><td align=\"right\" >",",");
                                line = line.Replace("</td></tr>","");

                                string[] lineitems = line.Split(new char[] {','});

                                int qty;
                                Int32.TryParse(lineitems[0],out qty);

                                double srcunitprice;
                                Double.TryParse(lineitems[1],out srcunitprice);

                                double destprice = Currency.Convert("USD","ZAR",srcunitprice);
                                PricingInfo p = new PricingInfo("USD","ZAR",srcunitprice,destprice,qty,999999);
                                priceslist.Add(p);
                            }                            
                            break;

                        case 3: // done
                            break;

                        default:
                            state = 0;
                            break;
                    }
                }

                // fix the maximum values
                for(i=0; i<(priceslist.Count()-1); i++)
                {
                     PricingInfo tp = priceslist[i];
                     tp.maxqty = priceslist[i+1].minqty - 1;
                     priceslist[i] = tp;
                }

                return priceslist.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Get the manufacturer from the webpage
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturer()
        {
            try
            {
                string res = "<UNKNOWN>";
                foreach(string line in WebPageLines)
                {
                    if (line.Contains("<tr><th align=right>Manufacturer</th>"))
                    {
                        // this line has the manufacturer
                        string m1 = "<span itemprop=\"name\">";
                        string m2 = "</span></a></span></h2></td></tr>";
                        int p1 = line.IndexOf(m1);
                        int p2 = line.IndexOf(m2,p1);
                        p1 += m1.Length;
                        res = line.Substring(p1,p2-p1);
                        return res;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Manufacturer Part number for digikey page
        /// </summary>
        /// <returns>Manufacturer part number</returns>
        public override string GetManufacturerPartNo()
        {
            try
            {
                string res = "<UNKNOWN>";
                foreach(string line in WebPageLines)
                {
                    if (line.Contains("<tr><th align=right>Manufacturer Part Number</th>"))
                    {
                        // this line has the manufacturer
                        string m1 = "itemprop=\"model\">";
                        string m2 = "</h1></td></tr>";
                        int p1 = line.IndexOf(m1);
                        int p2 = line.IndexOf(m2,p1);
                        p1 += m1.Length;
                        res = line.Substring(p1,p2-p1);
                        return res;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }

    /// <summary>
    /// RF Design webtools base
    /// </summary>
    public class RFDesignWebTools : SupplierWebToolsBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RFDesignWebTools() : base()
        {                
        }

        /// <summary>
        /// Get The manufacturer part number
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturerPartNo()
        {
 	        return PartNumber;
        }

        /// <summary>
        /// Get the manufacturer
        /// </summary>
        /// <returns></returns>
        public override string  GetManufacturer()
        {
 	        return "Not sure";
        }

        /// <summary>
        /// Get the pricing info on the part from the website
        /// </summary>
        /// <returns></returns>
        public override PricingInfo[] GetPricingInfo()
        {
            try
            {               
                List<PricingInfo> priceslist = new List<PricingInfo>(10);

                foreach(string line in WebPageLines)
                {
                    string m1 = "<SPAN id=productPrice>";
                    string m2 = "</SPAN>";
                    if (line.Contains(m1))
                    {
                        int p1 = line.IndexOf(m1);
                        int p2 = line.IndexOf(m2,p1);
                        p1 += m1.Length;
                        string pricestr = line.Substring(p1,p2-p1);
                        PricingInfo p = new PricingInfo();
                        Double.TryParse(pricestr,out p.DestCost);
                        Double.TryParse(pricestr,out p.SrcCost);
                        p.destCurr = "ZAR";
                        p.srcCurr  = "ZAR";
                        p.minqty   = 1;
                        p.maxqty   = 999999;

                        priceslist.Add(p);
                    }
                }
                return priceslist.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Build the website url
        /// </summary>
        /// <param name="pn"></param>
        public override void BuildUrl(string pn)
        {
            Url = "http://www.rfdesign.co.za/pages/5645456/Search-Results.asp?searchField=" + 
                pn + "&SearchType=products";
        }
    }

    /// <summary>
    /// Mantech Electronics website tools
    /// </summary>
    public class MantechWebTools : SupplierWebToolsBase
    {
        /// <summary>
        /// Build the Mantech URL
        /// </summary>
        /// <param name="pn">Mantech stockcode</param>
        public override void BuildUrl(string pn)
        {
            Url = "http://www.mantech.co.za/ProductInfo.aspx?Item="+pn;
        }

        /// <summary>
        /// Get the manufacturer from the Mantech webpage
        /// </summary>
        /// <returns>Manufacturer string</returns>
        public override string GetManufacturer()
        {
            try
            {
                string res = "";
                for(int i=0; i < WebPageLines.Count(); i++)
                {
                    string line = WebPageLines[i];
                    if (line.Contains("Manufacturer &nbsp;"))
                    {
                        res = StringUtils.GetTextBetweenMarkers(WebPageLines[i+5],"\">","</span>");
                        return res;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the manufacturer's partnumber from the mantech website
        /// </summary>
        /// <returns>Manufacturer's part number string</returns>
        public override string GetManufacturerPartNo()
        {
            try
            {
                string res = "";
                for(int i=0; i < WebPageLines.Count(); i++)
                {
                    string line = WebPageLines[i];
                    if (line.Contains("Part Number &nbsp;"))
                    {
                        res = StringUtils.GetTextBetweenMarkers(WebPageLines[i+5],"\">","</span>");
                        return res;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///  Get the pricing of the part from the Mantech website
        /// </summary>
        /// <returns>PricingInfo[] array</returns>
        public override PricingInfo[] GetPricingInfo()
        {
            try
            {
                int state = 0;
                List<PricingInfo> priceslist = new List<PricingInfo>(50);

                for(int i=0; (i < WebPageLines.Count()) && (state<2); i++)
                {
                    string line = WebPageLines[i];
                    switch (state)
                    {
                        case 0: // look for price marker
                            if (line.Contains("Price</td>"))
                            {
                                state = 1;
                            }
                            break;

                        case 1: // 
                            if (line.Contains("On Request"))
                            {
                                PricingInfo p = new PricingInfo(true);
                                priceslist.Add(p);
                                state = 2;
                            }
                            else if (line.Contains("<span id=\""))
                            {
                                // we have the start of pricing info
                                string t = "";
                                PricingInfo p = new PricingInfo();
                                
                                t = StringUtils.GetTextBetweenMarkers(WebPageLines[i],"\">","</span>");
                                Int32.TryParse(t,out p.minqty);

                                t = StringUtils.GetTextBetweenMarkers(WebPageLines[i+2],"\">","</span>");
                                Int32.TryParse(t,out p.maxqty);

                                t = StringUtils.GetTextBetweenMarkers(WebPageLines[i+6],"\">","</span>");
                                Double.TryParse(t,out p.SrcCost);
                                p.DestCost = p.SrcCost;
                                p.destCurr = "ZAR";
                                p.srcCurr  = "ZAR";
                                priceslist.Add(p);
                                i+= 8;
                            }
                            else if (line.Contains("</table>"))
                            {
                                // we are done with pricing for this part
                                state = 2;
                            }
                            break;

                        case 2:
                            break;

                        default:
                            state = 0;
                            break;
                    }
                }
                return priceslist.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

    /// <summary>
    /// Otto marketing webtools class
    /// </summary>
    public class OttoMarketingWebTools : SupplierWebToolsBase
    {
        /// <summary>
        /// Build Url for Otto marketing
        /// </summary>
        /// <param name="pn"></param>
        public override void BuildUrl(string pn)
        {
            /* Old URL: before Feb 2014
             * Url = "http://www.otto.co.za/index.php?page=product&p=" + pn; */
            Url = "http://www.otto.co.za/search/?q=" + pn;

        }

        /// <summary>
        /// Get manufacturer from otto marketing website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturer()
        {
            return "Cannot determine";
        }

        /// <summary>
        /// Get the partnumber from the Otto marketing website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturerPartNo()
        {
            return "Cannot determine";
        }

        /// <summary>
        /// Get the pricing information from the otto marketing website
        /// </summary>
        /// <returns></returns>
        public override PricingInfo[] GetPricingInfo()
        {
            try
            {
                int state = 0;
                List<PricingInfo> l = new List<PricingInfo>(5);
                foreach(string line in WebPageLines)
                {
                    switch(state)
                    {
                        case 0:
                            if (line.Contains("<b>Code:</b>"))
                            {
                                if (StringUtils.GetTextBetweenMarkers(line,"<b>Code:</b>","</a>").Trim() == PartNumber)
                                {
                                    state = 1;      
                                }
                            }
                            break;

                        case 1: 
                            if (line.Contains(" <a href="))
                            {
                                string pricetxt = StringUtils.GetTextBetweenMarkers(line,"/\">R","</a>").Trim();
                                PricingInfo p = new PricingInfo();
                                Double.TryParse(pricetxt,out p.DestCost);
                                p.SrcCost = p.DestCost;
                                p.destCurr = "ZAR";
                                p.srcCurr = "ZAR";
                                p.minqty = 1;
                                p.maxqty = 999999;
                                l.Add(p);
                                state = 2;
                            }
                            break;
                    }
                }
                return l.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

    /// <summary>
    /// Inplementation for other components
    /// In this case the component pricing is read from a database, thus strictly speaking
    /// this class on not a webtool but a database tool.
    /// </summary>
    public class other_comp_tools
    {
        /// <summary>
        /// Constructor for other_comp_tools
        /// </summary>
        public other_comp_tools()
        {
            m_pricearr = new PricingInfo[2];
            m_Supplier = "";
            m_Suppliercode = "";
            m_Manuf    = "";
            m_Manufpn  = "";
        }
        
        /// <summary>
        /// Returns the manufacturer
        /// </summary>
        /// <returns></returns>
        public string GetManufacturer()
        {
            return m_Manuf;
        }

        /// <summary>
        /// Returns the supplier
        /// </summary>
        /// <returns></returns>
        public string GetSupplier()
        {
            return m_Supplier;
        }

        /// <summary>
        /// Returns the suppliercode
        /// </summary>
        /// <returns></returns>
        public string GetSupplierCode()
        {
            return m_Suppliercode;
        }

        /// <summary>
        /// returns the manuf part number
        /// </summary>
        /// <returns></returns>
        public string GetManufacturerPartNo()
        {
            return m_Manufpn;
        }

        /// <summary>
        /// returns the pricing information
        /// </summary>
        /// <returns></returns>
        public PricingInfo[] GetPricingInfo()
        {
            return m_pricearr;
        }

        private PricingInfo[] m_pricearr;
        private string m_Supplier;
        private string m_Suppliercode;
        private string m_Manuf;
        private string m_Manufpn;

        /// <summary>
        /// Load the pricing info for"other" parts from database
        /// </summary>
        /// <param name="pn"></param>
        /// <param name="toCurrency"></param>
        /// <param name="conn"></param>
        public void LoadPricingInfo(string pn, MySqlConnection conn, string toCurrency = "ZAR")
        {
            try
            {
                bool OK = false;
                string sql = "SELECT * FROM partspriceinfo WHERE partdesc = '" + pn + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<PricingInfo> prices = new List<PricingInfo>();

                PricingInfo p = new PricingInfo();

                while (rdr.Read())
                {         
                    m_Supplier     = rdr[2].ToString().Trim();
                    m_Suppliercode = rdr[3].ToString().Trim();
                    m_Manuf        = rdr[4].ToString().Trim();
                    m_Manufpn      = rdr[5].ToString().Trim();

                    Int32.TryParse(rdr[6].ToString(),out p.minqty);
                    Int32.TryParse(rdr[7].ToString(),out p.maxqty);
                    p.srcCurr = rdr[8].ToString().Trim();
                    Double.TryParse(rdr[9].ToString(), out p.SrcCost);

                    p.DestCost = Currency.Convert(p.srcCurr,toCurrency,p.SrcCost);

                    prices.Add(p);
                    OK = true;
                }
                rdr.Close();

                if (!OK) throw new Exception(pn + " not found in database");

                m_pricearr = prices.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

    /// <summary>
    /// RS components supplier web tools
    /// </summary>
    public class rswebtools : SupplierWebToolsBase
    {
        private string m_url;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">Url of part of the web (excl RS partnumer itself)</param>
        public rswebtools(string url) : base()
        {
            m_url = url;
        }

        /// <summary>
        /// Build the RS web URL
        /// </summary>
        /// <param name="pn"></param>
        public override void BuildUrl(string pn)
        {
            Url = m_url + pn;
        }

        /// <summary>
        /// Get manufacturer from the RS website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturer()
        {
            try
            {
                string res = "";
                for(int i=0; i < WebPageLines.Count(); i++)
                {
                    string line = WebPageLines[i];
                    if (line.Contains("Manufacturer"))
                    {
                        res = StringUtils.GetTextBetweenMarkers(WebPageLines[i+2],"<span itemprop='name'>","</span>");
                        return res;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }

        /// <summary>
        /// Get the manufacturer from the RS website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturerPartNo()
        {
            try
            {
                string res = "";
                for(int i=0; i < WebPageLines.Count(); i++)
                {
                    string line = WebPageLines[i];
                    if (line.Contains("Mftr. Part No."))
                    {
                        res = StringUtils.GetTextBetweenMarkers(WebPageLines[i+1],"<span itemprop='mpn'>","</span>");
                        return res;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }

        List<PricingInfo> lp;

        private void m_GetPricingInfo(string content, bool IsHigherQuantitiesPage = false)
        {
            try
            {
                int idx = 0;
                int p1 = 0;
                string m1 = "class=\"dr-table-cell rich-table-cell quantity\">";
                string m2 = "</td>";
                string qtystr = "";
                string pricestr = "";
                string pr1 = "<span itemprop='price'><span class=\"nowrap\">R ";
                string pr2 = "</span>";

                bool HasMoreprices = true;
                while(HasMoreprices)
                {
                    p1 = content.IndexOf(m1,p1);

                    if (p1 >= 0)
                    {
                        int p2 = content.IndexOf(m2,p1);
                        p1 += m1.Length;
                        qtystr = content.Substring(p1,p2-p1);

                        p1 = content.IndexOf(pr1,p1);
                        p2 = content.IndexOf(pr2,p1);

                        p1 += pr1.Length;
                        pricestr = content.Substring(p1,p2-p1);

                        if ((IsHigherQuantitiesPage && (idx>0)) || (!IsHigherQuantitiesPage))
                        {
                            PricingInfo p = new PricingInfo();
                            p.destCurr = "ZAR";
                            p.srcCurr = "ZAR";
                            Double.TryParse(pricestr,out p.DestCost);
                            p.SrcCost = p.DestCost;

                            Int32.TryParse(qtystr,out p.minqty);
                            p.maxqty = 999999;
                            lp.Add(p);
                        }
                        idx++;
                    }
                    else
                    {
                        HasMoreprices = false;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the pricing information from the RS website
        /// </summary>
        /// <returns></returns>
        public override PricingInfo[] GetPricingInfo()
        {
            try
            {
                lp = new List<PricingInfo>(50);
                m_GetPricingInfo(WebPageContent); // for the main component site
                   
                if (WebPageContent.Contains("Higher Quantities"))
                {
                    string pricebreakdownpage = WebUtils.DownloadWebPage(Url + "P");
                    m_GetPricingInfo(pricebreakdownpage,true); // for the higher prices site
                }
            
                // fix the maximum values
                for(int i=0; i<(lp.Count()-1); i++)
                {
                    PricingInfo tp = lp[i];
                    tp.maxqty = lp[i+1].minqty - 1;
                    lp[i] = tp;
                }
                return lp.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

    /// <summary>
    /// Mouser website webtools
    /// NOTE: mouser generic search url :
    /// http://www.mouser.com/_/N-scv7?Keyword=
    /// </summary>
    public class MouserWebtools : SupplierWebToolsBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MouserWebtools()
        {
        }

        /// <summary>
        /// Build the URL string
        /// </summary>
        /// <param name="pn"></param>
        public override void BuildUrl(string pn)
        {            
            string temp = HttpUtility.UrlEncode(pn);
            // was: Url = @"http://www.mouser.com/_/N-scv7?Keyword=" + temp;

            // changed to accommodate parts not in stock
            Url = @"http://www.mouser.com/_/N-scv9?Keyword=" + temp;
        }

        /// <summary>
        /// Gte manufacturer from Mouser website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturer()
        {            
            try
            {                
                for(int i=0; i<WebPageLines.Count(); i++)
                {
                    string s = WebPageLines[i];
                    if (s.Contains("Manufacturer:</b>"))
                    {
                        string temp = WebPageLines[i+4].Trim();
                        return StringUtils.GetTextBetweenMarkers(temp,@""">",@"</a>");
                    }
                }
                return "";
            }
            catch(Exception ex)
            {
                throw ex;
            }  
        }

        /// <summary>
        /// Get Manufcaturer partnumber from the mouser website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturerPartNo()
        {            
            try
            {                
                string res = "";
                for(int i=0; i<WebPageLines.Count(); i++)
                {
                    string s = WebPageLines[i];
                    if (s.Contains("Manufacturer Part #:</b>"))
                    {
                        res = WebPageLines[i+5];
                        res = res.Replace("</h1>","");
                        return res.Trim();
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }  
        }

        /// <summary>
        /// Return pricing info from the mouser website
        /// </summary>
        /// <returns></returns>
        public override PricingInfo[] GetPricingInfo()
        {
            int i=0; 
            int state = 0;
            int qty = 0;
            double price;
            List<PricingInfo> priceslist = new List<PricingInfo>(50);

            try
            {
                while(( i < WebPageLines.Count()) && (state < 2))
                {
                    switch(state)
                    {
                        case 0:
                            if (WebPageLines[i].Contains(@"<table class=""PriceBreaks"" cellspacing=""0"">"))
                            {
                                state = 1;
                                i += 11;
                            }
                            else
                            {
                                i++;
                            }
                            break;

                        case 1:
                            string res = StringUtils.GetTextBetweenMarkers(WebPageLines[i],@""">","</a>");
                            res = neolibs.StringUtils.StringToNumericsOnly(res);
                            if (!Int32.TryParse(res,out qty))
                            {
                                throw new Exception("Invalid qty in mouser webpage.");
                            }

                            string pricestr;
                            if (!WebPageLines[i+3].Contains(@"Quote</></span>"))
                            {
                                pricestr = StringUtils.GetTextBetweenMarkers(WebPageLines[i+3],@""">$","</span>");
                                if (!Double.TryParse(pricestr,out price))
                                {
                                    throw new Exception("Invalid price in mouser webpage.");
                                }
                                double destprice = Currency.Convert("USD","ZAR",price);
                                PricingInfo p = new PricingInfo("USD","ZAR",price,destprice,qty,9999999);
                                priceslist.Add(p);

                            }
                            if ((WebPageLines[i+16] == "<tr>") && 
                                (!WebPageLines[i+3].Contains(@"Quote</></span>")))
                            {
                                i += 19;
                            }
                            else
                            {
                                state = 2;
                            }                        
                            break;

                        default:
                            break;
                    }
                }

                // fix the maximum values
                for(i=0; i<(priceslist.Count()-1); i++)
                {
                        PricingInfo tp = priceslist[i];
                        tp.maxqty = priceslist[i+1].minqty - 1;
                        priceslist[i] = tp;
                }

                return priceslist.ToArray();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }

    /// <summary>
    /// Orderline structure - for individual lines on the order
    /// </summary>
    public struct OrderLine
    {
        /// <summary>
        /// The supplier's code
        /// </summary>
        public string Supplier_pn;

        /// <summary>
        /// Part manufacturer
        /// </summary>
        public string Manufacturer;

        /// <summary>
        /// Manufacturer's part number
        /// </summary>
        public string Manufacturer_pn;

        /// <summary>
        /// A customer reference item
        /// </summary>
        public string CustomerRef;

        /// <summary>
        /// Quantity on orderline
        /// </summary>
        public int    qty;

        /// <summary>
        /// Recommended minimum buying quantity
        /// </summary>
        public int    recommended_moq;
    }

    /// <summary>
    /// Base class for automatic order generation
    /// </summary>
    public abstract class SupplierOrderBase
    {
        /// <summary>
        /// Order Lines (List of OrderLine)
        /// </summary>
        public List<OrderLine> OrderLines = new List<OrderLine>(1000);

        /// <summary>
        /// Check if an item is already in the order
        /// </summary>
        /// <param name="pn">partnumber</param>
        /// <returns>true if it is, false if it is not</returns>
        public bool ItemIsOnOrder(string pn)
        {
            try
            {
                bool res = false;
                foreach(OrderLine o in OrderLines)
                {
                    if (o.Supplier_pn == pn)
                    {
                        res = true;
                    }
                }
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add an amount to an existing partno on the orderlist
        /// </summary>
        /// <param name="pn"></param>
        /// <param name="q"></param>
        public void AddToOrderLine(string pn, int q)
        {
            try
            {
                for(int i=0; i<OrderLines.Count(); i++)
                {
                    OrderLine o = OrderLines[i];

                    if (o.Supplier_pn == pn)
                    {
                        o.qty += q;
                    }

                    OrderLines[i] = o;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public SupplierOrderBase()
        {
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~SupplierOrderBase()
        {
        }

        /// <summary>
        /// Abstract method to save order information to a file
        /// </summary>
        /// <param name="fn"></param>
        public abstract void SaveToFile(string fn);
    }

    /// <summary>
    /// A generic order class
    /// </summary>
    public class GenericOrder : SupplierOrderBase
    {
        /// <summary>
        /// Add Item to order
        /// </summary>
        /// <param name="ordercode"></param>
        /// <param name="qty"></param>
        public void AddToOrder(string ordercode, int qty)
        {
            if (ItemIsOnOrder(ordercode))
            {
                AddToOrderLine(ordercode,qty);
            }
            else
            {
                OrderLine o = new OrderLine();

                o.Supplier_pn     = ordercode;
                o.Manufacturer    = "";
                o.Manufacturer_pn = "";
                o.CustomerRef     = "";
                o.qty             = qty;

                OrderLines.Add(o);           
            }
        }

        /// <summary>
        /// Save the order to a file that can be imported into spreadsheet software
        /// </summary>
        /// <param name="fn">filename to save to</param>
        public override void SaveToFile(string fn)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(fn);
            file.WriteLine("Order code\tQty");

            foreach(OrderLine o in OrderLines)
            {
                file.Write(o.Supplier_pn+"\t");
                file.Write(o.qty);
                file.WriteLine();
            }
            file.Close();
        }

    }

    /// <summary>
    /// RF design orders are generic orders
    /// </summary>
    public class RFDesignOrder : GenericOrder
    {
    }

    /// <summary>
    /// Mantech Electronics Order
    /// </summary>
    public class MantechOrder : GenericOrder
    {
    }

    /// <summary>
    /// Otto Order class
    /// </summary>
    public class OttoOrder : GenericOrder
    {
    }

    /// <summary>
    /// RS component order class
    /// </summary>
    public class RsOrder : GenericOrder
    {
    }

    /// <summary>
    /// Other component orders
    /// </summary>
    public class OtherOrder : GenericOrder
    {
    }

    /// <summary>
    /// Mouser orders
    /// </summary>
    public class MouserOrder : GenericOrder 
    {
    }

    /// <summary>
    /// Class to generate digikey orders
    /// </summary>
    public class DigikeyOrder : SupplierOrderBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DigikeyOrder() : base ()
        {
        }

        /// <summary>
        /// Add an item to the order
        /// </summary>
        /// <param name="dk_pn">Digikey partnumber</param>
        /// <param name="manuf">Manufacturer</param>
        /// <param name="Manuf_pn">Manufacturer partnumber</param>
        /// <param name="Custref">Customer reference</param>
        /// <param name="qty">Quantity</param>
        /// <param name="rec_moq">Recommended buying quantity</param>
        public void AddToOrder(string dk_pn, string manuf, string Manuf_pn, int qty, string Custref, int rec_moq)
        {
            if (ItemIsOnOrder(dk_pn))
            {
                AddToOrderLine(dk_pn,qty);
            }
            else
            {
                OrderLine o = new OrderLine();

                o.Supplier_pn     = dk_pn;
                o.Manufacturer    = manuf;
                o.Manufacturer_pn = Manuf_pn;
                o.CustomerRef     = Custref;
                o.qty             = qty;
                o.recommended_moq = rec_moq;

                OrderLines.Add(o);           
            }
        }

        /// <summary>
        /// Save the order to a file that can be uploaded on digikey website
        /// </summary>
        /// <param name="fn">filename to save to</param>
        public override void SaveToFile(string fn)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(fn);
            // file.WriteLine("Digi-Key Part Number\tManufacturer Name\tManufacturer Part Number\tCustomer Reference\tQuantity 1\tQuantity 2\tQuantity 3");

            foreach(OrderLine o in OrderLines)
            {
                file.Write(o.Supplier_pn+"\t");
                file.Write(o.Manufacturer+"\t");
                file.Write(o.Manufacturer_pn+"\t");
                file.Write(o.CustomerRef+"\t");
                if (o.recommended_moq > o.qty)
                {
                    file.Write(o.recommended_moq);
                }
                else
                {
                    file.Write(o.qty);
                }
                file.WriteLine();
            }
            file.Close();
        }
    }
}
