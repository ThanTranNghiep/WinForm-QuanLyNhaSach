using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.SourceControl
{
    internal class Books
    {
        private String maSach;
        private String tenSach;
        private String maTL;
        private String maTG;
        private String maNXB;
        private int namXB;
        private String trongLuong;
        private String kichThuocBaoBi;
        private int soTrang;
        private float giaBan;
        private int soLuong;
        private String mota;

        public Books()
        {
            maSach = " ";
            tenSach = " ";
            maTL = " ";
            maTG = " ";
            maNXB = " ";
            namXB = 2000;
            trongLuong = " ";
            kichThuocBaoBi = " ";
            soTrang = 10;
            giaBan = 0;
            soLuong = 0;
            mota = " ";
        }

        public Books(string maSach, string tenSach, string maTL, string maTG, string maNXB, int namXB, string trongLuong, string kichThuocBaoBi, int soTrang, float giaBan, int soLuong, string mota)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.maTL = maTL;
            this.maTG = maTG;
            this.maNXB = maNXB;
            this.namXB = namXB;
            this.trongLuong = trongLuong;
            this.kichThuocBaoBi = kichThuocBaoBi;
            this.soTrang = soTrang;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
            this.mota = mota;
        }


        public String MaSach
        {
            set { this.maSach = value; }
            get { return this.maSach; }
        }
        public string TenSach
        {
            set { this.tenSach = value; }
            get { return this.tenSach; }
        }
        public String MaTL
        {
            set { this.maTL = value; }
            get { return this.maTL; }
        }

        public String MaTG
        {
            set { this.maTG = value; }
            get { return this.maTG; }
        }
        public String MaNXB
        {
            set { this.maNXB = value; }
            get { return this.maNXB;}
        }
        public int NamXB
        {
            set { this.namXB = value; }
            get { return this.namXB;}
        }
        public String TrongLuong
        {
            set { this.trongLuong = value; }
            get { return this.trongLuong;}
        }
        public String KichThuocBaoBi
        {
            set { this.kichThuocBaoBi = value; }
            get { return this.kichThuocBaoBi;}
        }
        public int SoTrang
        {
            set { this.soTrang = value; }
            get { return this.soTrang;}
        }
        public float GiaBan
        {
            set { this.giaBan = value; }    
            get { return this.giaBan; }
        }
        public int SoLuong
        {
            set { this.soLuong = value; }
            get { return this.soLuong;}
        }
        public String MoTa
        {
            set { this.mota = value; }
            get { return this.mota; }
        }
    }
}
