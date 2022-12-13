//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Mobile.Crud{
	internal class LabPanelmCrud {
		///<summary>Gets one LabPanelm object from the database using primaryKey1(CustomerNum) and primaryKey2.  Returns null if not found.</summary>
		internal static LabPanelm SelectOne(long customerNum,long labPanelNum){
			string command="SELECT * FROM labpanelm "
				+"WHERE CustomerNum = "+POut.Long(customerNum)+" AND LabPanelNum = "+POut.Long(labPanelNum);
			List<LabPanelm> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one LabPanelm object from the database using a query.</summary>
		internal static LabPanelm SelectOne(string command){
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<LabPanelm> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of LabPanelm objects from the database using a query.</summary>
		internal static List<LabPanelm> SelectMany(string command){
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<LabPanelm> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		internal static List<LabPanelm> TableToList(DataTable table){
			List<LabPanelm> retVal=new List<LabPanelm>();
			LabPanelm labPanelm;
			for(int i=0;i<table.Rows.Count;i++) {
				labPanelm=new LabPanelm();
				labPanelm.CustomerNum      = PIn.Long  (table.Rows[i]["CustomerNum"].ToString());
				labPanelm.LabPanelNum      = PIn.Long  (table.Rows[i]["LabPanelNum"].ToString());
				labPanelm.PatNum           = PIn.Long  (table.Rows[i]["PatNum"].ToString());
				labPanelm.LabNameAddress   = PIn.String(table.Rows[i]["LabNameAddress"].ToString());
				labPanelm.SpecimenCondition= PIn.String(table.Rows[i]["SpecimenCondition"].ToString());
				labPanelm.SpecimenSource   = PIn.String(table.Rows[i]["SpecimenSource"].ToString());
				labPanelm.ServiceId        = PIn.String(table.Rows[i]["ServiceId"].ToString());
				labPanelm.ServiceName      = PIn.String(table.Rows[i]["ServiceName"].ToString());
				labPanelm.MedicalOrderNum  = PIn.Long  (table.Rows[i]["MedicalOrderNum"].ToString());
				retVal.Add(labPanelm);
			}
			return retVal;
		}

		///<summary>Usually set useExistingPK=true.  Inserts one LabPanelm into the database.</summary>
		internal static long Insert(LabPanelm labPanelm,bool useExistingPK){
			if(!useExistingPK) {
				labPanelm.LabPanelNum=ReplicationServers.GetKey("labpanelm","LabPanelNum");
			}
			string command="INSERT INTO labpanelm (";
			command+="LabPanelNum,";
			command+="CustomerNum,PatNum,LabNameAddress,SpecimenCondition,SpecimenSource,ServiceId,ServiceName,MedicalOrderNum) VALUES(";
			command+=POut.Long(labPanelm.LabPanelNum)+",";
			command+=
				     POut.Long  (labPanelm.CustomerNum)+","
				+    POut.Long  (labPanelm.PatNum)+","
				+"'"+POut.String(labPanelm.LabNameAddress)+"',"
				+"'"+POut.String(labPanelm.SpecimenCondition)+"',"
				+"'"+POut.String(labPanelm.SpecimenSource)+"',"
				+"'"+POut.String(labPanelm.ServiceId)+"',"
				+"'"+POut.String(labPanelm.ServiceName)+"',"
				+    POut.Long  (labPanelm.MedicalOrderNum)+")";
			Db.NonQ(command);//There is no autoincrement in the mobile server.
			return labPanelm.LabPanelNum;
		}

		///<summary>Updates one LabPanelm in the database.</summary>
		internal static void Update(LabPanelm labPanelm){
			string command="UPDATE labpanelm SET "
				+"PatNum           =  "+POut.Long  (labPanelm.PatNum)+", "
				+"LabNameAddress   = '"+POut.String(labPanelm.LabNameAddress)+"', "
				+"SpecimenCondition= '"+POut.String(labPanelm.SpecimenCondition)+"', "
				+"SpecimenSource   = '"+POut.String(labPanelm.SpecimenSource)+"', "
				+"ServiceId        = '"+POut.String(labPanelm.ServiceId)+"', "
				+"ServiceName      = '"+POut.String(labPanelm.ServiceName)+"', "
				+"MedicalOrderNum  =  "+POut.Long  (labPanelm.MedicalOrderNum)+" "
				+"WHERE CustomerNum = "+POut.Long(labPanelm.CustomerNum)+" AND LabPanelNum = "+POut.Long(labPanelm.LabPanelNum);
			Db.NonQ(command);
		}

		///<summary>Deletes one LabPanelm from the database.</summary>
		internal static void Delete(long customerNum,long labPanelNum){
			string command="DELETE FROM labpanelm "
				+"WHERE CustomerNum = "+POut.Long(customerNum)+" AND LabPanelNum = "+POut.Long(labPanelNum);
			Db.NonQ(command);
		}

		///<summary>Converts one LabPanel object to its mobile equivalent.  Warning! CustomerNum will always be 0.</summary>
		internal static LabPanelm ConvertToM(LabPanel labPanel){
			LabPanelm labPanelm=new LabPanelm();
			//CustomerNum cannot be set.  Remains 0.
			labPanelm.LabPanelNum      =labPanel.LabPanelNum;
			labPanelm.PatNum           =labPanel.PatNum;
			labPanelm.LabNameAddress   =labPanel.LabNameAddress;
			labPanelm.SpecimenCondition=labPanel.SpecimenCondition;
			labPanelm.SpecimenSource   =labPanel.SpecimenSource;
			labPanelm.ServiceId        =labPanel.ServiceId;
			labPanelm.ServiceName      =labPanel.ServiceName;
			labPanelm.MedicalOrderNum  =labPanel.MedicalOrderNum;
			return labPanelm;
		}

	}
}