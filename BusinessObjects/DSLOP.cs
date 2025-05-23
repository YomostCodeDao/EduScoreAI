﻿using System;

namespace QLTHPT1.BusinessObjects
{
	public class DSLOP
	{
		#region ***** Fields & Properties ***** 
		private int _MaLop;
        private string _tenKhoi;

        public string TenKhoi
        {
            get { return _tenKhoi; }
            set { _tenKhoi = value; }
        }
		public int MaLop
		{ 
			get 
			{ 
				return _MaLop;
			}
			set 
			{ 
				_MaLop = value;
			}
		}
		private string _TenLop;
		public string TenLop
		{ 
			get 
			{ 
				return _TenLop;
			}
			set 
			{ 
				_TenLop = value;
			}
		}
		private int _MaKhoi;
		public int MaKhoi
		{ 
			get 
			{ 
				return _MaKhoi;
			}
			set 
			{ 
				_MaKhoi = value;
			}
		}
		private int _SiSo;
		public int SiSo
		{ 
			get 
			{ 
				return _SiSo;
			}
			set 
			{ 
				_SiSo = value;
			}
		}
		private string _MaGiaoVien;
		public string MaGiaoVien
		{ 
			get 
			{ 
				return _MaGiaoVien;
			}
			set 
			{ 
				_MaGiaoVien = value;
			}
		}
		private string _MoTaKhac;
		public string MoTaKhac
		{ 
			get 
			{ 
				return _MoTaKhac;
			}
			set 
			{ 
				_MoTaKhac = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public DSLOP()
		{
		}
		public DSLOP(int malop)
		{
			this.MaLop = malop;
		}
		public DSLOP(int malop, string tenlop, int makhoi, int siso, string magiaovien, string motakhac)
		{
			this.MaLop = malop;
			this.TenLop = tenlop;
			this.MaKhoi = makhoi;
			this.SiSo = siso;
			this.MaGiaoVien = magiaovien;
			this.MoTaKhac = motakhac;
		}
		#endregion
	}
}
