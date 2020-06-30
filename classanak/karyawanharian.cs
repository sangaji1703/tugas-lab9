using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiKaryawan2646.ClassInduk;
namespace AplikasiKaryawan2646.ClassAnak

{
    public class KaryawanHarian : Karyawan
    {
        public int UpahPerJam { get; set; }
        public int JumlahJamKerja { get; set; }

        public override int Gaji() => UpahPerJam * JumlahJamKerja;

