//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class ComputerPrefCrud {
		///<summary>Gets one ComputerPref object from the database using the primary key.  Returns null if not found.</summary>
		public static ComputerPref SelectOne(long computerPrefNum) {
			string command="SELECT * FROM computerpref "
				+"WHERE ComputerPrefNum = "+POut.Long(computerPrefNum);
			List<ComputerPref> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one ComputerPref object from the database using a query.</summary>
		public static ComputerPref SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ComputerPref> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of ComputerPref objects from the database using a query.</summary>
		public static List<ComputerPref> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<ComputerPref> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<ComputerPref> TableToList(DataTable table) {
			List<ComputerPref> retVal=new List<ComputerPref>();
			ComputerPref computerPref;
			foreach(DataRow row in table.Rows) {
				computerPref=new ComputerPref();
				computerPref.ComputerPrefNum        = PIn.Long  (row["ComputerPrefNum"].ToString());
				computerPref.ComputerName           = PIn.String(row["ComputerName"].ToString());
				computerPref.GraphicsUseHardware    = PIn.Bool  (row["GraphicsUseHardware"].ToString());
				computerPref.GraphicsSimple         = (OpenDentBusiness.DrawingMode)PIn.Int(row["GraphicsSimple"].ToString());
				computerPref.SensorType             = PIn.String(row["SensorType"].ToString());
				computerPref.SensorBinned           = PIn.Bool  (row["SensorBinned"].ToString());
				computerPref.SensorPort             = PIn.Int   (row["SensorPort"].ToString());
				computerPref.SensorExposure         = PIn.Int   (row["SensorExposure"].ToString());
				computerPref.GraphicsDoubleBuffering= PIn.Bool  (row["GraphicsDoubleBuffering"].ToString());
				computerPref.PreferredPixelFormatNum= PIn.Int   (row["PreferredPixelFormatNum"].ToString());
				computerPref.AtoZpath               = PIn.String(row["AtoZpath"].ToString());
				computerPref.TaskKeepListHidden     = PIn.Bool  (row["TaskKeepListHidden"].ToString());
				computerPref.TaskDock               = PIn.Int   (row["TaskDock"].ToString());
				computerPref.TaskX                  = PIn.Int   (row["TaskX"].ToString());
				computerPref.TaskY                  = PIn.Int   (row["TaskY"].ToString());
				computerPref.DirectXFormat          = PIn.String(row["DirectXFormat"].ToString());
				computerPref.ScanDocSelectSource    = PIn.Bool  (row["ScanDocSelectSource"].ToString());
				computerPref.ScanDocShowOptions     = PIn.Bool  (row["ScanDocShowOptions"].ToString());
				computerPref.ScanDocDuplex          = PIn.Bool  (row["ScanDocDuplex"].ToString());
				computerPref.ScanDocGrayscale       = PIn.Bool  (row["ScanDocGrayscale"].ToString());
				computerPref.ScanDocResolution      = PIn.Int   (row["ScanDocResolution"].ToString());
				computerPref.ScanDocQuality         = PIn.Byte  (row["ScanDocQuality"].ToString());
				computerPref.ClinicNum              = PIn.Long  (row["ClinicNum"].ToString());
				computerPref.ApptViewNum            = PIn.Long  (row["ApptViewNum"].ToString());
				computerPref.RecentApptView         = PIn.Byte  (row["RecentApptView"].ToString());
				computerPref.PatSelectSearchMode    = (OpenDentBusiness.SearchMode)PIn.Int(row["PatSelectSearchMode"].ToString());
				computerPref.NoShowLanguage         = PIn.Bool  (row["NoShowLanguage"].ToString());
				computerPref.NoShowDecimal          = PIn.Bool  (row["NoShowDecimal"].ToString());
				string computerOS=row["ComputerOS"].ToString();
				if(computerOS=="") {
					computerPref.ComputerOS           =(OpenDentBusiness.PlatformOD)0;
				}
				else try{
					computerPref.ComputerOS           =(OpenDentBusiness.PlatformOD)Enum.Parse(typeof(OpenDentBusiness.PlatformOD),computerOS);
				}
				catch{
					computerPref.ComputerOS           =(OpenDentBusiness.PlatformOD)0;
				}
				computerPref.HelpButtonXAdjustment  = PIn.Double(row["HelpButtonXAdjustment"].ToString());
				computerPref.GraphicsUseDirectX11   = (OpenDentBusiness.YN)PIn.Int(row["GraphicsUseDirectX11"].ToString());
				computerPref.Zoom                   = PIn.Int   (row["Zoom"].ToString());
				computerPref.VideoRectangle         = PIn.String(row["VideoRectangle"].ToString());
				retVal.Add(computerPref);
			}
			return retVal;
		}

		///<summary>Converts a list of ComputerPref into a DataTable.</summary>
		public static DataTable ListToTable(List<ComputerPref> listComputerPrefs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="ComputerPref";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("ComputerPrefNum");
			table.Columns.Add("ComputerName");
			table.Columns.Add("GraphicsUseHardware");
			table.Columns.Add("GraphicsSimple");
			table.Columns.Add("SensorType");
			table.Columns.Add("SensorBinned");
			table.Columns.Add("SensorPort");
			table.Columns.Add("SensorExposure");
			table.Columns.Add("GraphicsDoubleBuffering");
			table.Columns.Add("PreferredPixelFormatNum");
			table.Columns.Add("AtoZpath");
			table.Columns.Add("TaskKeepListHidden");
			table.Columns.Add("TaskDock");
			table.Columns.Add("TaskX");
			table.Columns.Add("TaskY");
			table.Columns.Add("DirectXFormat");
			table.Columns.Add("ScanDocSelectSource");
			table.Columns.Add("ScanDocShowOptions");
			table.Columns.Add("ScanDocDuplex");
			table.Columns.Add("ScanDocGrayscale");
			table.Columns.Add("ScanDocResolution");
			table.Columns.Add("ScanDocQuality");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("ApptViewNum");
			table.Columns.Add("RecentApptView");
			table.Columns.Add("PatSelectSearchMode");
			table.Columns.Add("NoShowLanguage");
			table.Columns.Add("NoShowDecimal");
			table.Columns.Add("ComputerOS");
			table.Columns.Add("HelpButtonXAdjustment");
			table.Columns.Add("GraphicsUseDirectX11");
			table.Columns.Add("Zoom");
			table.Columns.Add("VideoRectangle");
			foreach(ComputerPref computerPref in listComputerPrefs) {
				table.Rows.Add(new object[] {
					POut.Long  (computerPref.ComputerPrefNum),
					            computerPref.ComputerName,
					POut.Bool  (computerPref.GraphicsUseHardware),
					POut.Int   ((int)computerPref.GraphicsSimple),
					            computerPref.SensorType,
					POut.Bool  (computerPref.SensorBinned),
					POut.Int   (computerPref.SensorPort),
					POut.Int   (computerPref.SensorExposure),
					POut.Bool  (computerPref.GraphicsDoubleBuffering),
					POut.Int   (computerPref.PreferredPixelFormatNum),
					            computerPref.AtoZpath,
					POut.Bool  (computerPref.TaskKeepListHidden),
					POut.Int   (computerPref.TaskDock),
					POut.Int   (computerPref.TaskX),
					POut.Int   (computerPref.TaskY),
					            computerPref.DirectXFormat,
					POut.Bool  (computerPref.ScanDocSelectSource),
					POut.Bool  (computerPref.ScanDocShowOptions),
					POut.Bool  (computerPref.ScanDocDuplex),
					POut.Bool  (computerPref.ScanDocGrayscale),
					POut.Int   (computerPref.ScanDocResolution),
					POut.Byte  (computerPref.ScanDocQuality),
					POut.Long  (computerPref.ClinicNum),
					POut.Long  (computerPref.ApptViewNum),
					POut.Byte  (computerPref.RecentApptView),
					POut.Int   ((int)computerPref.PatSelectSearchMode),
					POut.Bool  (computerPref.NoShowLanguage),
					POut.Bool  (computerPref.NoShowDecimal),
					POut.Int   ((int)computerPref.ComputerOS),
					POut.Double(computerPref.HelpButtonXAdjustment),
					POut.Int   ((int)computerPref.GraphicsUseDirectX11),
					POut.Int   (computerPref.Zoom),
					            computerPref.VideoRectangle,
				});
			}
			return table;
		}

		///<summary>Inserts one ComputerPref into the database.  Returns the new priKey.</summary>
		public static long Insert(ComputerPref computerPref) {
			return Insert(computerPref,false);
		}

		///<summary>Inserts one ComputerPref into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(ComputerPref computerPref,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				computerPref.ComputerPrefNum=ReplicationServers.GetKey("computerpref","ComputerPrefNum");
			}
			string command="INSERT INTO computerpref (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="ComputerPrefNum,";
			}
			command+="ComputerName,GraphicsUseHardware,GraphicsSimple,SensorType,SensorBinned,SensorPort,SensorExposure,GraphicsDoubleBuffering,PreferredPixelFormatNum,AtoZpath,TaskKeepListHidden,TaskDock,TaskX,TaskY,DirectXFormat,ScanDocSelectSource,ScanDocShowOptions,ScanDocDuplex,ScanDocGrayscale,ScanDocResolution,ScanDocQuality,ClinicNum,ApptViewNum,RecentApptView,PatSelectSearchMode,NoShowLanguage,NoShowDecimal,ComputerOS,HelpButtonXAdjustment,GraphicsUseDirectX11,Zoom,VideoRectangle) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(computerPref.ComputerPrefNum)+",";
			}
			command+=
				 "'"+POut.String(computerPref.ComputerName)+"',"
				+    POut.Bool  (computerPref.GraphicsUseHardware)+","
				+    POut.Int   ((int)computerPref.GraphicsSimple)+","
				+"'"+POut.String(computerPref.SensorType)+"',"
				+    POut.Bool  (computerPref.SensorBinned)+","
				+    POut.Int   (computerPref.SensorPort)+","
				+    POut.Int   (computerPref.SensorExposure)+","
				+    POut.Bool  (computerPref.GraphicsDoubleBuffering)+","
				+    POut.Int   (computerPref.PreferredPixelFormatNum)+","
				+"'"+POut.String(computerPref.AtoZpath)+"',"
				+    POut.Bool  (computerPref.TaskKeepListHidden)+","
				+    POut.Int   (computerPref.TaskDock)+","
				+    POut.Int   (computerPref.TaskX)+","
				+    POut.Int   (computerPref.TaskY)+","
				+"'"+POut.String(computerPref.DirectXFormat)+"',"
				+    POut.Bool  (computerPref.ScanDocSelectSource)+","
				+    POut.Bool  (computerPref.ScanDocShowOptions)+","
				+    POut.Bool  (computerPref.ScanDocDuplex)+","
				+    POut.Bool  (computerPref.ScanDocGrayscale)+","
				+    POut.Int   (computerPref.ScanDocResolution)+","
				+    POut.Byte  (computerPref.ScanDocQuality)+","
				+    POut.Long  (computerPref.ClinicNum)+","
				+    POut.Long  (computerPref.ApptViewNum)+","
				+    POut.Byte  (computerPref.RecentApptView)+","
				+    POut.Int   ((int)computerPref.PatSelectSearchMode)+","
				+    POut.Bool  (computerPref.NoShowLanguage)+","
				+    POut.Bool  (computerPref.NoShowDecimal)+","
				+"'"+POut.String(computerPref.ComputerOS.ToString())+"',"
				+		 POut.Double(computerPref.HelpButtonXAdjustment)+","
				+    POut.Int   ((int)computerPref.GraphicsUseDirectX11)+","
				+    POut.Int   (computerPref.Zoom)+","
				+"'"+POut.String(computerPref.VideoRectangle)+"')";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				computerPref.ComputerPrefNum=Db.NonQ(command,true,"ComputerPrefNum","computerPref");
			}
			return computerPref.ComputerPrefNum;
		}

		///<summary>Inserts one ComputerPref into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ComputerPref computerPref) {
			return InsertNoCache(computerPref,false);
		}

		///<summary>Inserts one ComputerPref into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(ComputerPref computerPref,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO computerpref (";
			if(!useExistingPK && isRandomKeys) {
				computerPref.ComputerPrefNum=ReplicationServers.GetKeyNoCache("computerpref","ComputerPrefNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="ComputerPrefNum,";
			}
			command+="ComputerName,GraphicsUseHardware,GraphicsSimple,SensorType,SensorBinned,SensorPort,SensorExposure,GraphicsDoubleBuffering,PreferredPixelFormatNum,AtoZpath,TaskKeepListHidden,TaskDock,TaskX,TaskY,DirectXFormat,ScanDocSelectSource,ScanDocShowOptions,ScanDocDuplex,ScanDocGrayscale,ScanDocResolution,ScanDocQuality,ClinicNum,ApptViewNum,RecentApptView,PatSelectSearchMode,NoShowLanguage,NoShowDecimal,ComputerOS,HelpButtonXAdjustment,GraphicsUseDirectX11,Zoom,VideoRectangle) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(computerPref.ComputerPrefNum)+",";
			}
			command+=
				 "'"+POut.String(computerPref.ComputerName)+"',"
				+    POut.Bool  (computerPref.GraphicsUseHardware)+","
				+    POut.Int   ((int)computerPref.GraphicsSimple)+","
				+"'"+POut.String(computerPref.SensorType)+"',"
				+    POut.Bool  (computerPref.SensorBinned)+","
				+    POut.Int   (computerPref.SensorPort)+","
				+    POut.Int   (computerPref.SensorExposure)+","
				+    POut.Bool  (computerPref.GraphicsDoubleBuffering)+","
				+    POut.Int   (computerPref.PreferredPixelFormatNum)+","
				+"'"+POut.String(computerPref.AtoZpath)+"',"
				+    POut.Bool  (computerPref.TaskKeepListHidden)+","
				+    POut.Int   (computerPref.TaskDock)+","
				+    POut.Int   (computerPref.TaskX)+","
				+    POut.Int   (computerPref.TaskY)+","
				+"'"+POut.String(computerPref.DirectXFormat)+"',"
				+    POut.Bool  (computerPref.ScanDocSelectSource)+","
				+    POut.Bool  (computerPref.ScanDocShowOptions)+","
				+    POut.Bool  (computerPref.ScanDocDuplex)+","
				+    POut.Bool  (computerPref.ScanDocGrayscale)+","
				+    POut.Int   (computerPref.ScanDocResolution)+","
				+    POut.Byte  (computerPref.ScanDocQuality)+","
				+    POut.Long  (computerPref.ClinicNum)+","
				+    POut.Long  (computerPref.ApptViewNum)+","
				+    POut.Byte  (computerPref.RecentApptView)+","
				+    POut.Int   ((int)computerPref.PatSelectSearchMode)+","
				+    POut.Bool  (computerPref.NoShowLanguage)+","
				+    POut.Bool  (computerPref.NoShowDecimal)+","
				+"'"+POut.String(computerPref.ComputerOS.ToString())+"',"
				+	   POut.Double(computerPref.HelpButtonXAdjustment)+","
				+    POut.Int   ((int)computerPref.GraphicsUseDirectX11)+","
				+    POut.Int   (computerPref.Zoom)+","
				+"'"+POut.String(computerPref.VideoRectangle)+"')";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				computerPref.ComputerPrefNum=Db.NonQ(command,true,"ComputerPrefNum","computerPref");
			}
			return computerPref.ComputerPrefNum;
		}

		///<summary>Updates one ComputerPref in the database.</summary>
		public static void Update(ComputerPref computerPref) {
			string command="UPDATE computerpref SET "
				+"ComputerName           = '"+POut.String(computerPref.ComputerName)+"', "
				+"GraphicsUseHardware    =  "+POut.Bool  (computerPref.GraphicsUseHardware)+", "
				+"GraphicsSimple         =  "+POut.Int   ((int)computerPref.GraphicsSimple)+", "
				+"SensorType             = '"+POut.String(computerPref.SensorType)+"', "
				+"SensorBinned           =  "+POut.Bool  (computerPref.SensorBinned)+", "
				+"SensorPort             =  "+POut.Int   (computerPref.SensorPort)+", "
				+"SensorExposure         =  "+POut.Int   (computerPref.SensorExposure)+", "
				+"GraphicsDoubleBuffering=  "+POut.Bool  (computerPref.GraphicsDoubleBuffering)+", "
				+"PreferredPixelFormatNum=  "+POut.Int   (computerPref.PreferredPixelFormatNum)+", "
				+"AtoZpath               = '"+POut.String(computerPref.AtoZpath)+"', "
				+"TaskKeepListHidden     =  "+POut.Bool  (computerPref.TaskKeepListHidden)+", "
				+"TaskDock               =  "+POut.Int   (computerPref.TaskDock)+", "
				+"TaskX                  =  "+POut.Int   (computerPref.TaskX)+", "
				+"TaskY                  =  "+POut.Int   (computerPref.TaskY)+", "
				+"DirectXFormat          = '"+POut.String(computerPref.DirectXFormat)+"', "
				+"ScanDocSelectSource    =  "+POut.Bool  (computerPref.ScanDocSelectSource)+", "
				+"ScanDocShowOptions     =  "+POut.Bool  (computerPref.ScanDocShowOptions)+", "
				+"ScanDocDuplex          =  "+POut.Bool  (computerPref.ScanDocDuplex)+", "
				+"ScanDocGrayscale       =  "+POut.Bool  (computerPref.ScanDocGrayscale)+", "
				+"ScanDocResolution      =  "+POut.Int   (computerPref.ScanDocResolution)+", "
				+"ScanDocQuality         =  "+POut.Byte  (computerPref.ScanDocQuality)+", "
				+"ClinicNum              =  "+POut.Long  (computerPref.ClinicNum)+", "
				+"ApptViewNum            =  "+POut.Long  (computerPref.ApptViewNum)+", "
				+"RecentApptView         =  "+POut.Byte  (computerPref.RecentApptView)+", "
				+"PatSelectSearchMode    =  "+POut.Int   ((int)computerPref.PatSelectSearchMode)+", "
				+"NoShowLanguage         =  "+POut.Bool  (computerPref.NoShowLanguage)+", "
				+"NoShowDecimal          =  "+POut.Bool  (computerPref.NoShowDecimal)+", "
				+"ComputerOS             = '"+POut.String(computerPref.ComputerOS.ToString())+"', "
				+"HelpButtonXAdjustment  =  "+POut.Double(computerPref.HelpButtonXAdjustment)+", "
				+"GraphicsUseDirectX11   =  "+POut.Int   ((int)computerPref.GraphicsUseDirectX11)+", "
				+"Zoom                   =  "+POut.Int   (computerPref.Zoom)+", "
				+"VideoRectangle         = '"+POut.String(computerPref.VideoRectangle)+"' "
				+"WHERE ComputerPrefNum = "+POut.Long(computerPref.ComputerPrefNum);
			Db.NonQ(command);
		}

		///<summary>Updates one ComputerPref in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(ComputerPref computerPref,ComputerPref oldComputerPref) {
			string command="";
			if(computerPref.ComputerName != oldComputerPref.ComputerName) {
				if(command!="") { command+=",";}
				command+="ComputerName = '"+POut.String(computerPref.ComputerName)+"'";
			}
			if(computerPref.GraphicsUseHardware != oldComputerPref.GraphicsUseHardware) {
				if(command!="") { command+=",";}
				command+="GraphicsUseHardware = "+POut.Bool(computerPref.GraphicsUseHardware)+"";
			}
			if(computerPref.GraphicsSimple != oldComputerPref.GraphicsSimple) {
				if(command!="") { command+=",";}
				command+="GraphicsSimple = "+POut.Int   ((int)computerPref.GraphicsSimple)+"";
			}
			if(computerPref.SensorType != oldComputerPref.SensorType) {
				if(command!="") { command+=",";}
				command+="SensorType = '"+POut.String(computerPref.SensorType)+"'";
			}
			if(computerPref.SensorBinned != oldComputerPref.SensorBinned) {
				if(command!="") { command+=",";}
				command+="SensorBinned = "+POut.Bool(computerPref.SensorBinned)+"";
			}
			if(computerPref.SensorPort != oldComputerPref.SensorPort) {
				if(command!="") { command+=",";}
				command+="SensorPort = "+POut.Int(computerPref.SensorPort)+"";
			}
			if(computerPref.SensorExposure != oldComputerPref.SensorExposure) {
				if(command!="") { command+=",";}
				command+="SensorExposure = "+POut.Int(computerPref.SensorExposure)+"";
			}
			if(computerPref.GraphicsDoubleBuffering != oldComputerPref.GraphicsDoubleBuffering) {
				if(command!="") { command+=",";}
				command+="GraphicsDoubleBuffering = "+POut.Bool(computerPref.GraphicsDoubleBuffering)+"";
			}
			if(computerPref.PreferredPixelFormatNum != oldComputerPref.PreferredPixelFormatNum) {
				if(command!="") { command+=",";}
				command+="PreferredPixelFormatNum = "+POut.Int(computerPref.PreferredPixelFormatNum)+"";
			}
			if(computerPref.AtoZpath != oldComputerPref.AtoZpath) {
				if(command!="") { command+=",";}
				command+="AtoZpath = '"+POut.String(computerPref.AtoZpath)+"'";
			}
			if(computerPref.TaskKeepListHidden != oldComputerPref.TaskKeepListHidden) {
				if(command!="") { command+=",";}
				command+="TaskKeepListHidden = "+POut.Bool(computerPref.TaskKeepListHidden)+"";
			}
			if(computerPref.TaskDock != oldComputerPref.TaskDock) {
				if(command!="") { command+=",";}
				command+="TaskDock = "+POut.Int(computerPref.TaskDock)+"";
			}
			if(computerPref.TaskX != oldComputerPref.TaskX) {
				if(command!="") { command+=",";}
				command+="TaskX = "+POut.Int(computerPref.TaskX)+"";
			}
			if(computerPref.TaskY != oldComputerPref.TaskY) {
				if(command!="") { command+=",";}
				command+="TaskY = "+POut.Int(computerPref.TaskY)+"";
			}
			if(computerPref.DirectXFormat != oldComputerPref.DirectXFormat) {
				if(command!="") { command+=",";}
				command+="DirectXFormat = '"+POut.String(computerPref.DirectXFormat)+"'";
			}
			if(computerPref.ScanDocSelectSource != oldComputerPref.ScanDocSelectSource) {
				if(command!="") { command+=",";}
				command+="ScanDocSelectSource = "+POut.Bool(computerPref.ScanDocSelectSource)+"";
			}
			if(computerPref.ScanDocShowOptions != oldComputerPref.ScanDocShowOptions) {
				if(command!="") { command+=",";}
				command+="ScanDocShowOptions = "+POut.Bool(computerPref.ScanDocShowOptions)+"";
			}
			if(computerPref.ScanDocDuplex != oldComputerPref.ScanDocDuplex) {
				if(command!="") { command+=",";}
				command+="ScanDocDuplex = "+POut.Bool(computerPref.ScanDocDuplex)+"";
			}
			if(computerPref.ScanDocGrayscale != oldComputerPref.ScanDocGrayscale) {
				if(command!="") { command+=",";}
				command+="ScanDocGrayscale = "+POut.Bool(computerPref.ScanDocGrayscale)+"";
			}
			if(computerPref.ScanDocResolution != oldComputerPref.ScanDocResolution) {
				if(command!="") { command+=",";}
				command+="ScanDocResolution = "+POut.Int(computerPref.ScanDocResolution)+"";
			}
			if(computerPref.ScanDocQuality != oldComputerPref.ScanDocQuality) {
				if(command!="") { command+=",";}
				command+="ScanDocQuality = "+POut.Byte(computerPref.ScanDocQuality)+"";
			}
			if(computerPref.ClinicNum != oldComputerPref.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(computerPref.ClinicNum)+"";
			}
			if(computerPref.ApptViewNum != oldComputerPref.ApptViewNum) {
				if(command!="") { command+=",";}
				command+="ApptViewNum = "+POut.Long(computerPref.ApptViewNum)+"";
			}
			if(computerPref.RecentApptView != oldComputerPref.RecentApptView) {
				if(command!="") { command+=",";}
				command+="RecentApptView = "+POut.Byte(computerPref.RecentApptView)+"";
			}
			if(computerPref.PatSelectSearchMode != oldComputerPref.PatSelectSearchMode) {
				if(command!="") { command+=",";}
				command+="PatSelectSearchMode = "+POut.Int   ((int)computerPref.PatSelectSearchMode)+"";
			}
			if(computerPref.NoShowLanguage != oldComputerPref.NoShowLanguage) {
				if(command!="") { command+=",";}
				command+="NoShowLanguage = "+POut.Bool(computerPref.NoShowLanguage)+"";
			}
			if(computerPref.NoShowDecimal != oldComputerPref.NoShowDecimal) {
				if(command!="") { command+=",";}
				command+="NoShowDecimal = "+POut.Bool(computerPref.NoShowDecimal)+"";
			}
			if(computerPref.ComputerOS != oldComputerPref.ComputerOS) {
				if(command!="") { command+=",";}
				command+="ComputerOS = '"+POut.String(computerPref.ComputerOS.ToString())+"'";
			}
			if(computerPref.HelpButtonXAdjustment != oldComputerPref.HelpButtonXAdjustment) {
				if(command!="") { command+=",";}
				command+="HelpButtonXAdjustment = "+POut.Double(computerPref.HelpButtonXAdjustment)+"";
			}
			if(computerPref.GraphicsUseDirectX11 != oldComputerPref.GraphicsUseDirectX11) {
				if(command!="") { command+=",";}
				command+="GraphicsUseDirectX11 = "+POut.Int   ((int)computerPref.GraphicsUseDirectX11)+"";
			}
			if(computerPref.Zoom != oldComputerPref.Zoom) {
				if(command!="") { command+=",";}
				command+="Zoom = "+POut.Int(computerPref.Zoom)+"";
			}
			if(computerPref.VideoRectangle != oldComputerPref.VideoRectangle) {
				if(command!="") { command+=",";}
				command+="VideoRectangle = '"+POut.String(computerPref.VideoRectangle)+"'";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE computerpref SET "+command
				+" WHERE ComputerPrefNum = "+POut.Long(computerPref.ComputerPrefNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(ComputerPref,ComputerPref) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(ComputerPref computerPref,ComputerPref oldComputerPref) {
			if(computerPref.ComputerName != oldComputerPref.ComputerName) {
				return true;
			}
			if(computerPref.GraphicsUseHardware != oldComputerPref.GraphicsUseHardware) {
				return true;
			}
			if(computerPref.GraphicsSimple != oldComputerPref.GraphicsSimple) {
				return true;
			}
			if(computerPref.SensorType != oldComputerPref.SensorType) {
				return true;
			}
			if(computerPref.SensorBinned != oldComputerPref.SensorBinned) {
				return true;
			}
			if(computerPref.SensorPort != oldComputerPref.SensorPort) {
				return true;
			}
			if(computerPref.SensorExposure != oldComputerPref.SensorExposure) {
				return true;
			}
			if(computerPref.GraphicsDoubleBuffering != oldComputerPref.GraphicsDoubleBuffering) {
				return true;
			}
			if(computerPref.PreferredPixelFormatNum != oldComputerPref.PreferredPixelFormatNum) {
				return true;
			}
			if(computerPref.AtoZpath != oldComputerPref.AtoZpath) {
				return true;
			}
			if(computerPref.TaskKeepListHidden != oldComputerPref.TaskKeepListHidden) {
				return true;
			}
			if(computerPref.TaskDock != oldComputerPref.TaskDock) {
				return true;
			}
			if(computerPref.TaskX != oldComputerPref.TaskX) {
				return true;
			}
			if(computerPref.TaskY != oldComputerPref.TaskY) {
				return true;
			}
			if(computerPref.DirectXFormat != oldComputerPref.DirectXFormat) {
				return true;
			}
			if(computerPref.ScanDocSelectSource != oldComputerPref.ScanDocSelectSource) {
				return true;
			}
			if(computerPref.ScanDocShowOptions != oldComputerPref.ScanDocShowOptions) {
				return true;
			}
			if(computerPref.ScanDocDuplex != oldComputerPref.ScanDocDuplex) {
				return true;
			}
			if(computerPref.ScanDocGrayscale != oldComputerPref.ScanDocGrayscale) {
				return true;
			}
			if(computerPref.ScanDocResolution != oldComputerPref.ScanDocResolution) {
				return true;
			}
			if(computerPref.ScanDocQuality != oldComputerPref.ScanDocQuality) {
				return true;
			}
			if(computerPref.ClinicNum != oldComputerPref.ClinicNum) {
				return true;
			}
			if(computerPref.ApptViewNum != oldComputerPref.ApptViewNum) {
				return true;
			}
			if(computerPref.RecentApptView != oldComputerPref.RecentApptView) {
				return true;
			}
			if(computerPref.PatSelectSearchMode != oldComputerPref.PatSelectSearchMode) {
				return true;
			}
			if(computerPref.NoShowLanguage != oldComputerPref.NoShowLanguage) {
				return true;
			}
			if(computerPref.NoShowDecimal != oldComputerPref.NoShowDecimal) {
				return true;
			}
			if(computerPref.ComputerOS != oldComputerPref.ComputerOS) {
				return true;
			}
			if(computerPref.HelpButtonXAdjustment != oldComputerPref.HelpButtonXAdjustment) {
				return true;
			}
			if(computerPref.GraphicsUseDirectX11 != oldComputerPref.GraphicsUseDirectX11) {
				return true;
			}
			if(computerPref.Zoom != oldComputerPref.Zoom) {
				return true;
			}
			if(computerPref.VideoRectangle != oldComputerPref.VideoRectangle) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one ComputerPref from the database.</summary>
		public static void Delete(long computerPrefNum) {
			string command="DELETE FROM computerpref "
				+"WHERE ComputerPrefNum = "+POut.Long(computerPrefNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many ComputerPrefs from the database.</summary>
		public static void DeleteMany(List<long> listComputerPrefNums) {
			if(listComputerPrefNums==null || listComputerPrefNums.Count==0) {
				return;
			}
			string command="DELETE FROM computerpref "
				+"WHERE ComputerPrefNum IN("+string.Join(",",listComputerPrefNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}