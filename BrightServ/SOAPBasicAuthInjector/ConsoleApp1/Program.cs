using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAPBasicAuthInjector.AR_GetOracleInvoiceNumber;

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


			/*
			var createInvoiceRequest = new SOAPBasicAuthInjector.AR_CreateInvoice.InoviceData_createInvoice_REQUEST();
			//InvoiceDatar
			SOAPBasicAuthInjector.AR_CreateInvoice.InvoiceDataRequest[] requests = new SOAPBasicAuthInjector.AR_CreateInvoice.InvoiceDataRequest[1];
			requests[0] = new SOAPBasicAuthInjector.AR_CreateInvoice.InvoiceDataRequest();
			//requests[0].
			createInvoiceRequest.InsertInvoiceData(requests);
			*/

			var getUserNameRequest = new SOAPBasicAuthInjector.GenPactUserInfo.EmpServicePort_GetUserName_REQUEST();
	
			var getUserRequest = new SOAPBasicAuthInjector.GenPactUserInfo.request();
			getUserRequest.id = "123";
	  
		   var response = getUserNameRequest.requestOperation(getUserRequest);
			//getUserNameRequest.requestOperationAsync(getUserRequest);

		}
	}
}
