using System;
using System.Net;
using System.Text;

namespace SOAPBasicAuthInjector.CommonOverride
{
	internal static class WebRequestCustom
	{
		internal static WebRequest GetWebRequestCustom(HttpWebRequest request, NetworkCredential networkCredentials )
		{
			if (networkCredentials != null)
			{
				byte[] credentialBuffer = new UTF8Encoding().GetBytes(
					networkCredentials.UserName + ":" +
					networkCredentials.Password);
				request.Headers["Authorization"] =
					"Basic " + Convert.ToBase64String(credentialBuffer);
			}
			else
			{
				throw new ApplicationException("No network credentials");
			}
			return request;
		}
	}
}

namespace SOAPBasicAuthInjector.GenPactUserInfo
{
	public partial class EmpServicePort_GetUserName_REQUEST
	{
        protected override WebRequest GetWebRequest(Uri uri)
        {
			return CommonOverride.WebRequestCustom.GetWebRequestCustom((HttpWebRequest)base.GetWebRequest(uri), Credentials.GetCredential(uri, "Basic"));
		}         
    }
}

namespace SOAPBasicAuthInjector.AR_CreateInvoice
{
	public partial class InoviceData_InsertInvoice_REQUEST		
	{
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return CommonOverride.WebRequestCustom.GetWebRequestCustom((HttpWebRequest)base.GetWebRequest(uri), Credentials.GetCredential(uri, "Basic"));
		}
	}
}


namespace SOAPBasicAuthInjector.AR_CreditNote
{
	
	public partial class CreditNote_CreditNote_REQUEST
	{
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return CommonOverride.WebRequestCustom.GetWebRequestCustom((HttpWebRequest)base.GetWebRequest(uri), Credentials.GetCredential(uri, "Basic"));
		}
	}
}

namespace SOAPBasicAuthInjector.AR_GetOracleInvoiceNumber
{
	public partial class OracleInvoiceNumber_Oracleinovice_REQUEST
	{
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return CommonOverride.WebRequestCustom.GetWebRequestCustom((HttpWebRequest)base.GetWebRequest(uri), Credentials.GetCredential(uri, "Basic"));
		}
	}
}

namespace SOAPBasicAuthInjector.AR_GetOutstandingAmount
{
	public partial class GetInvoiceStatus_Invoice_Status_REQUEST
	{
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return CommonOverride.WebRequestCustom.GetWebRequestCustom((HttpWebRequest)base.GetWebRequest(uri), Credentials.GetCredential(uri, "Basic"));
		}
	}
}

namespace SOAPBasicAuthInjector.AP_CreateCase
{
	public partial class Create_Case_From_PNMSoft_Akritiv_REQUESTPortType_CreateCase_REQUEST
	{
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return CommonOverride.WebRequestCustom.GetWebRequestCustom((HttpWebRequest)base.GetWebRequest(uri), Credentials.GetCredential(uri, "Basic"));
		}
	}
}




