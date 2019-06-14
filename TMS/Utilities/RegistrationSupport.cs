using System;
using System.Data;
using TMS;

namespace Framework
{

    public static class RegistrationSupport
    {

        public static String username = null;
        public static String user_completename = null;
        public static Boolean IsCorrectUsernameAndPassword(String username, String password)
        {
            Boolean result = true;
            try
            {
                username = username.EscapeString();
                password = password.EscapeString();
                String sql = String.Format("SELECT * FROM Accounts WHERE username = '{0}' AND password = '{1}' ", username,  SecuritySupport.Encrypt( password));
                DataTable dt = Connection.GetTMSConnection.ExecuteDataSet(sql).Tables[0];//  DataSupport.RunDataSet(sql).Tables[0];
                if (dt.Rows.Count == 0)
                    throw new Exception();

                user_completename = String.Format("{0} {1}", dt.Rows[0]["first_name"].ToString(), dt.Rows[0]["last_name"].ToString());
                Utils.branch = dt.Rows[0]["branch"].ToString();
            }
            catch (Exception)
            {
                result = false;
            }


            return result;
        }
    }
}