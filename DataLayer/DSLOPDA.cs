﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using QLTHPT1.BusinessObjects;

namespace QLTHPT1.DataAccess
{
	public class DSLOPDA
	{

		#region ***** Init Methods ***** 
		public DSLOPDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DSLOP Populate(IDataReader myReader)
		{
			DSLOP obj = new DSLOP();
			obj.MaLop = (int) myReader["MaLop"];
			obj.TenLop = (string) myReader["TenLop"];
			obj.MaKhoi = (int) myReader["MaKhoi"];
			obj.SiSo = (int) myReader["SiSo"];
			//obj.MaGiaoVien = (string) myReader["MaGiaoVien"];
			obj.MoTaKhac = (string) myReader["MoTaKhac"];
			return obj;
		}
        public DSLOP Populate2(IDataReader myReader)
        {
            DSLOP obj = new DSLOP();
            obj.MaLop = (int)myReader["MaLop"];
            obj.TenLop = (string)myReader["TenLop"];         
            return obj;
        }
        public DSLOP Populate3(IDataReader myReader)
        {
            DSLOP obj = new DSLOP();
            obj.MaLop = (int)myReader["MaLop"];
            obj.TenLop = (string)myReader["TenLop"];
            obj.SiSo = (int)myReader["SiSo"];
            obj.TenKhoi = (string)myReader["TenKhoi"];
            obj.MoTaKhac = (string)myReader["MoTaKhac"];
            return obj;
        }
        public DSLOP Populate1(IDataReader myReader)
        {
            DSLOP obj = new DSLOP();
           
            obj.TenLop = (string)myReader["TenLop"];
            
            return obj;
        }

        /// <summary>
		/// Get DSLOP by malop
		/// </summary>
		/// <param name="malop">MaLop</param>
		/// <returns>DSLOP</returns>
		public List<DSLOP> GetByMaLop(int malop)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_GetByMaLop", Data.CreateParameter("MaLop", malop)))
			{
                List<DSLOP> list = new List<DSLOP>();
				while (reader.Read())
				{
					list.Add( Populate(reader));
				}
				return list;
			}
		}
        public List<DSLOP> GetByMaLop1(int malop)
        {
            using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_GetByMaLop1", Data.CreateParameter("MaLop", malop)))
            {
                List<DSLOP> list = new List<DSLOP>();
                while (reader.Read())
                {
                    list.Add( Populate1(reader));
                }
                return list;
            }
        }
		/// <summary>
		/// Get all of DSLOP
		/// </summary>
		/// <returns>List<<DSLOP>></returns>
		public List<DSLOP> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_Get"))
			{
				List<DSLOP> list = new List<DSLOP>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

        public List<DSLOP> GetByMaKhoi(int makhoi)
        {
            using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_GetByMaKhoi", Data.CreateParameter("MaKhoi", makhoi)))
            {
                
                List<DSLOP> list = new List<DSLOP>();
                while (reader.Read())
                {
                    list.Add(Populate(reader));
                }
                return list;
            }
        }

        public List<DSLOP> GetByMaKhoiXem(int makhoi)
        {
            using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_GetByMaKhoiXem", Data.CreateParameter("MaKhoi", makhoi)))
            {

                List<DSLOP> list = new List<DSLOP>();
                while (reader.Read())
                {
                    list.Add(Populate3(reader));
                }
                return list;
            }
        }

        public List<DSLOP> GetByMaKhoiKtra(int makhoi,string tenlop)
        {
            using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_GetByMaKhoiKtra", Data.CreateParameter("MaKhoi", makhoi),Data.CreateParameter("TenLop",tenlop)))
            {

                List<DSLOP> list = new List<DSLOP>();
                while (reader.Read())
                {
                    list.Add(Populate2(reader));
                }
                return list;
            }
        }
        public List<DSLOP> GetByMaKhoiGV(int makhoi,string maGv)
        {
            using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_GetByMaKhoiGV", Data.CreateParameter("MaKhoi", makhoi), Data.CreateParameter("MaGiaoVien", maGv)))
            {

                List<DSLOP> list = new List<DSLOP>();
                while (reader.Read())
                {
                    list.Add(Populate(reader));
                }
                return list;
            }
        }
		/// <summary>
		/// Get DataSet of DSLOP
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DSLOP_Get");
		}


		/// <summary>
		/// Get all of DSLOP paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<DSLOP>></returns>
		public List<DSLOP> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DSLOP_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<DSLOP> list = new List<DSLOP>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DSLOP paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DSLOP_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DSLOP within DSLOP database table
		/// </summary>
		/// <param name="obj">DSLOP</param>
		/// <returns>key of table</returns>
		public int Add(DSLOP obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MaLop", obj.MaLop);
			//parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DSLOP_Add"
							,parameterItemID
							,Data.CreateParameter("TenLop", obj.TenLop)
							,Data.CreateParameter("MaKhoi", obj.MaKhoi)
							,Data.CreateParameter("SiSo", obj.SiSo)
						
							,Data.CreateParameter("MoTaKhac", obj.MoTaKhac)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified DSLOP
		/// </summary>
		/// <param name="obj">DSLOP</param>
		/// <returns></returns>
		public void Update(DSLOP obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DSLOP_Update"
							,Data.CreateParameter("MaLop", obj.MaLop)
							,Data.CreateParameter("TenLop", obj.TenLop)
							,Data.CreateParameter("MaKhoi", obj.MaKhoi)
							,Data.CreateParameter("SiSo", obj.SiSo)
							
							,Data.CreateParameter("MoTaKhac", obj.MoTaKhac)
			);
		}

		/// <summary>
		/// Delete the specified DSLOP
		/// </summary>
		/// <param name="malop">MaLop</param>
		/// <returns></returns>
		public void Delete(int malop)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DSLOP_Delete", Data.CreateParameter("MaLop", malop));
		}
		#endregion
	}
}
