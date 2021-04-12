using deadline_15_04.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deadline_15_04
{
    class MyResources
    {
        private static Boolean autoLoadDMP = false;
        private static Boolean autoLoadPC = false;
        private static Boolean autoLoadDV = false;
        private static RapPhim rapPhim;
        private static DanhMucPhim form_DanhMucPhim;
        private static DatVe form_DatVe;
        private static PhongChieuPhim form_PhongChieuPhim;
        private static RapPhim_main form_RapPhim;

        public static Boolean AutoLoadDMP
        {
            get { return autoLoadDMP; }
            set { autoLoadDMP = value; }
        }
        public static Boolean AutoLoadPC
        {
            get { return autoLoadPC; }
            set { autoLoadPC = value; }
        }
        public static Boolean AutoLoadDV
        {
            get { return autoLoadDV; }
            set { autoLoadDV = value; }
        }
        public static RapPhim MyRapPhim
        {
            get { return rapPhim; }
        }
        public static DanhMucPhim Form_DanhMucPhim
        {
            get { return form_DanhMucPhim; }
            set { form_DanhMucPhim = value; }
        }
        public static DatVe Form_DatVe
        {
            get { return form_DatVe; }
            set { form_DatVe = value; }
        }
        public static PhongChieuPhim Form_PhongChieuPhim
        {
            get { return form_PhongChieuPhim; }
            set { form_PhongChieuPhim = value; }
        }
        public static RapPhim_main Form_RapPhim
        {
            get { return form_RapPhim; }
            set { form_RapPhim = value; }
        }
        static public void Init()
        {
            rapPhim = new RapPhim();
        }

        /**
         * 
         * Form handle
         */
        #region Form handle
        static public void ShowFormDanhMucPhim()
        {
            
            if (Form_DanhMucPhim == null || Form_DanhMucPhim.IsDisposed == true)
            {
                Form_DanhMucPhim = new DanhMucPhim
                {
                    Visible = true
                };
            }

            Form_DanhMucPhim.Activate();
            return;
        }
        static public void ShowFormDatVe()
        {
            if (Form_DatVe == null || Form_DatVe.IsDisposed == true)
            {
                Form_DatVe = new DatVe
                {
                    Visible = true
                };
            }

            Form_DatVe.Activate();
            return;
        }
        static public void ShowFormPhongChieuPhim()
        {
            if (Form_PhongChieuPhim == null || Form_PhongChieuPhim.IsDisposed == true)
            {
                Form_PhongChieuPhim = new PhongChieuPhim
                {
                    Visible = true
                };
            }

            Form_PhongChieuPhim.Activate();
            return;
        }
        static public void ShowFormRapPhim()
        {
            if (Form_RapPhim == null || Form_RapPhim.IsDisposed == true)
            {
                Form_RapPhim = new RapPhim_main
                {
                    Visible = true
                }; 
            }

            Form_RapPhim.Activate();
            return;
        }
        #endregion
        
        static public void DistroyForm()
        {
            Form_DanhMucPhim?.Dispose();
            Form_DatVe?.Dispose();
            Form_PhongChieuPhim?.Dispose();
            Form_RapPhim?.Dispose();
        }
    }
}
