using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsFuzzerCS
{
    public class pduFuctions
    {

        public static string StringToHex(string hexstring)
        {
            var sb = new StringBuilder();
            foreach (char t in hexstring)
                sb.Append(Convert.ToInt32(t).ToString("x"));
            return sb.ToString();
        }

        public static string StringToHex18Bit(string hexstring)
        {
            var sb = new StringBuilder();
            foreach (char t in hexstring)
                sb.Append("00"+Convert.ToInt32(t).ToString("x"));
            return sb.ToString();
        }

        public static Boolean isNumberOdd(int numberlen)
        {
            return numberlen % 2 != 0;
        }

        public static string SwapNumber(string number)
        {
            if (isNumberOdd(number.Length))
            {
                number += "F";
            }
            int loopcount = number.Length;
            //char[] charArray = receiver.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < loopcount / 2; x++)
            {
                String temp = number.Substring(0, 2);
                char[] charArray = temp.ToCharArray();
                Array.Reverse(charArray);
                sb.Append(new string(charArray));
                number = number.Substring(2);
            } number = sb.ToString();
            return number;
        }


        public static string createPduSms(string number, string msg, string sms_type, Boolean delreport)
        {
            string DEL_REPORT = "01",
                   PDU_STRING = "",
                   HEX18STRING = "";

            string NUMBER = SwapNumber(number),
                   SMSTEXT = msg,
                   SMS_TYPE = sms_type;

            int iNUMBER_LEN = number.Length,
                iSMS_LEN = msg.Length * 2;// need to double length for 18 bit encoding

            string xNUMBER_LEN = iNUMBER_LEN.ToString("X"),
                   xSMS_LEN = iSMS_LEN.ToString("X");

            if(iNUMBER_LEN <= 15)
            {
                xNUMBER_LEN = "0" + xNUMBER_LEN;
            }

            if(delreport)
            {
                DEL_REPORT = "21";
            }else
            {
                DEL_REPORT = "01";
            }
		

	        HEX18STRING = StringToHex18Bit(SMSTEXT); 
	        if (iSMS_LEN <= 15)
            {
		        PDU_STRING = String.Format("00{0}00{1}91{2}00{3}0{4}{5}",
                                        DEL_REPORT,
                                        xNUMBER_LEN,
                                        NUMBER,
                                        SMS_TYPE,
                                        xSMS_LEN,
                                        HEX18STRING);
	        }else if(iSMS_LEN > 15)
            {
                PDU_STRING = String.Format("00{0}00{1}91{2}00{3}{4}{5}",
                                        DEL_REPORT,
                                        xNUMBER_LEN,
                                        NUMBER,
                                        SMS_TYPE,
                                        xSMS_LEN,
                                        HEX18STRING);
            }

            return PDU_STRING;
        }
    }
}
