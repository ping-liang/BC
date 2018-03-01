using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAPBasicAuthInjector.AR_GetOracleInvoiceNumber;
using System.Net;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*

			PNMInvoiceNum[] pnmNumbers = new PNMInvoiceNum[2];
			pnmNumbers[0] = new PNMInvoiceNum();
			pnmNumbers[0].PNMInvoiceNo = "11111111";
			pnmNumbers[1] = new PNMInvoiceNum();
			pnmNumbers[1].PNMInvoiceNo = "22222222";

			var oracleInvoiceReqest = new OracleInvoiceNumber_Oracleinovice_REQUEST();
			var oraclNumbers =   oracleInvoiceReqest.GetOracleInvoiceNumber(pnmNumbers);
			*/



			var createInvoiceRequest = new SOAPBasicAuthInjector.AR_CreateInvoice.InoviceData_createInvoice_REQUEST();
			System.Net.CredentialCache myCredentials = new System.Net.CredentialCache();
			NetworkCredential netCred = new NetworkCredential("ICSSupport.Genpact@genpact.com", "Identity@123");
			myCredentials.Add(new Uri(createInvoiceRequest.Url), "Basic", netCred);
			createInvoiceRequest.Credentials = myCredentials;
	
			//createInvoiceRequest.
			//InvoiceDatar
			SOAPBasicAuthInjector.AR_CreateInvoice.InvoiceDataRequest[] requests = new SOAPBasicAuthInjector.AR_CreateInvoice.InvoiceDataRequest[1];
			requests[0] = new SOAPBasicAuthInjector.AR_CreateInvoice.InvoiceDataRequest();
			requests[0].Amount = 100;
			requests[0].BatchSourceName = "BrightServ";
			requests[0].CurrencyCode = "USD";
			requests[0].CustTrxTypeName = "Tax";
			requests[0].Description = "Testing";
			requests[0].GLDate = DateTime.Now;
			requests[0].InterfaceLineAttribute1 = "111112";
			requests[0].InterfaceLineAttribute2 = "33333";
			requests[0].InterfaceLineAttribute3 = "33333";
			requests[0].InterfaceLineContext = "BrightServ";
			requests[0].LineNumber = "1";
			requests[0].LineType = "Line";
			requests[0].MemoLineName = "Line";
			requests[0].OrigSystemBillAddressRef = "389 Washingto Street";
			requests[0].OrigSystemBillCustomerRef = "Test P";
			requests[0].OrigSystemShipAddressRef = "3535 Main St";
			requests[0].OrigSystemShipCustomerRef = "Ted";
			requests[0].OrigSystemSoldCustomerRef = "Ted";
			requests[0].Quantity = 1;
			requests[0].TermName = "30 DAYS";
			requests[0].TaxRate = 0;
			requests[0].UnitSellingPrice = 100;



			//createInvoiceRequest.InsertInvoiceData(requests);

			createInvoiceRequest.InsertInvoiceDataAsync(requests);



		}
	}
}
