using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using CodeBase;
using DataConnectionBase;

namespace OpenDentBusiness {
	///<summary>You don't generally use this class.  Use Db instead except in special situations.</summary>
	public class DataCore {
		///<summary></summary>
		public static DataTable GetTable(string command) {
			using(DataConnection dcon=new DataConnection()) {
				return ExecuteQueryFunc(() => dcon.GetTable(command));
			}
		}

		///<summary>Only used if using the server component.  This is used for queries written by the user.  It uses the user with lower privileges  to prevent injection attack.</summary>
		public static DataTable GetTableLow(string command) {
			using(DataConnection dcon=new DataConnection(true)) {
				return ExecuteQueryFunc(() => dcon.GetTable(command));
			}
		}

		public static List<T> GetList<T>(string command,Func<IDataRecord,T> rowToObjMethod) {
			using(DataConnection dcon=new DataConnection()) {
				return ExecuteQueryFunc(() => dcon.GetList(command,rowToObjMethod));
			}
		}

		///<summary>Sends a non query command to the database and returns the number of rows affected.
		///This query is run with full privileges.  This is for commands generated by the main program, and the user will not have access for injection attacks.
		///If getInsertID is true, then InsertID will be set to the value of the primary key of the newly inserted row.
		///WILL NOT RETURN CORRECT PRIMARY KEY for MySQL if the query specifies the primary key.
		///Pass in the PK column and table names so that Oracle can correctly lock the table and know which column to return for the Insert ID.</summary>
		public static long NonQ(string command,bool getInsertID,string columnNamePK,string tableName,params OdSqlParameter[] parameters) {
			long retval=0;
			using(DataConnection dcon=new DataConnection()) {
				retval=ExecuteQueryFunc(() =>
					dcon.NonQ(command,getInsertID,columnNamePK,tableName,true,parameters.Select(x => x.GetMySqlParameter()).ToArray())
				);
				if(getInsertID) {
					retval=dcon.InsertID;
				}
			}
			return retval;
		}

		///<summary>This query is run with full privileges.  This is for commands generated by the main program, and the user will not have access for injection attacks.  Result is usually number of rows changed, or can be insert id if requested.  WILL NOT RETURN CORRECT PRIMARY KEY if the query specifies the primary key.</summary>
		public static long NonQ(string command,bool getInsertID,params OdSqlParameter[] parameters) {
			return NonQ(command,getInsertID,"","",parameters);
		}

		public static long NonQ(string command,params OdSqlParameter[] parameters) {
			return NonQ(command,false,parameters);
		}

		///<summary>Get one single value.</summary>
		public static string GetScalar(string command) {
			using(DataConnection dcon=new DataConnection()) {
				return ExecuteQueryFunc(() => dcon.GetScalar(command));
			}
		}

		///<summary>Generic helper method that executes the func passed in.
		///The ODException will preserve whatever unhandled exception was thrown but will also include the command that was attempted.</summary>
		public static T ExecuteQueryFunc<T>(Func<T> f) {
			T retVal=default;
			try {
				retVal=f();
			}
			catch(Exception ex) {
				if(ex.Message.ToLower().Contains("fatal error")) {
					throw new ODException("Query Execution Error",Db.LastCommand,ex);
				}
				throw ex;
			}
			return retVal;
		}

	

	}

	
}
