﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QLTHPT1.BusinessObjects;

namespace QLTHPT1.DataAccess
{
	public class BANNERDA
	{

		#region ***** Init Methods ***** 
		public BANNERDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public BANNER Populate(IDataReader myReader)
		{
			BANNER obj = new BANNER();
			obj.TenBanner = (string) myReader["TenBanner"];
			obj.Link = (string) myReader["Link"];
			obj.MoTa = (string) myReader["MoTa"];
			return obj;
		}


		/// <summary>
		/// Get all of BANNER
		/// </summary>
		/// <returns>List<<BANNER>></returns>
		public List<BANNER> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_BANNER_Get"))
			{
				List<BANNER> list = new List<BANNER>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of BANNER
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_BANNER_Get");
		}

        public DataSet GetFindBanner(string TenBanner)
        {
            return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure, "sp_getFind_BANNER"
                             , Data.CreateParameter("TenBanner", TenBanner));
        }

		/// <summary>
		/// Get all of BANNER paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<BANNER>></returns>
		public List<BANNER> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_BANNER_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<BANNER> list = new List<BANNER>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of BANNER paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_BANNER_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new BANNER within BANNER database table
		/// </summary>
		/// <param name="obj">BANNER</param>
		/// <returns>key of table</returns>
		public int Add(BANNER obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_BANNER_Add"
							,Data.CreateParameter("TenBanner", obj.TenBanner)
							,Data.CreateParameter("Link", obj.Link)
							,Data.CreateParameter("MoTa", obj.MoTa)
			);
			return 0;
		}
        public void Update(BANNER obj)
        {
            SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure, "sproc_BANNER_Update"
                          , Data.CreateParameter("TenBanner", obj.TenBanner)
                            , Data.CreateParameter("Link", obj.Link)
                           , Data.CreateParameter("MoTa", obj.MoTa)
            );
        }


        public void Delete(string tenbanner)
        {
            SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure, "sproc_BANNER_Delete", Data.CreateParameter("TenBanner", tenbanner));
        }
//No key Found
		#endregion
	}
}
