using DefaultMIx64.Entities;
using DefaultMIx64.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DefaultMIx64.Core
{
    public class Collective
    {

        /// <summary>
        /// Obje oluşturma işlemi 
        /// </summary>
        /// <param name="objeSay"></param>
        public void ObjeOlustur(int objeSay)
        {
            try
            {
                int i;
                for (i = 0; i < objeSay; i++)
                {
                    if (i == 0)
                    {
                        MapInfoClass.Instance.Do("dim o as object");
                    }
                    else
                    {
                        MapInfoClass.Instance.Do("dim o" + Convert.ToString(i + 1) + " as object");
                    }

                }
            }
            catch
            {
                MessageBox.Show("obje olustururken sorun oluştu", "Dikkat");
            }
        }

        /// <summary>
        /// Olusturulan objeyi silme işlemi.
        /// </summary>
        /// <param name="objeSay"></param>
        public void ObjeSil(int objeSay)
        {
            try
            {
                int i;
                for (i = 0; i < objeSay; i++)
                {
                    if (i == 0)
                    {
                        MapInfoClass.Instance.Do("undim o");
                    }
                    else
                    {
                        MapInfoClass.Instance.Do("undim o" + Convert.ToString(i + 1));
                    }

                }
            }
            catch
            {
                MessageBox.Show("obje olustururken sorun oluştu", "Dikkat");
            }
        }

        /// <summary>
        /// Maden ocagi olusturma işlemi.
        /// </summary>
        /// <param name="rowid"></param>
        /// <param name="islem"></param>
        /// <returns></returns>
        public Maden_Ocagi MadenOcagiOlustur(string rowid, string islem)
        {
            Maden_Ocagi maden_Ocagi = new Maden_Ocagi();

            try
            {
                MapInfoClass.Instance.Do("dim o2 as object");
                maden_Ocagi.Id = Convert.ToInt32(rowid);
                MapInfoClass.Instance.Do("select * from Maden_Ocagi where rowid=" + rowid + " into secim noselect"); //objeyi secim tablosuna atadık
                MapInfoClass.Instance.Do("o=secim.obj");
                string query3 = "select IL_ADI,AREA(Overlap(obj, o), " + '"' + "sq km" + '"' + ") AS " + "\"" + "ALAN" + "\" from iller where obj intersects o into kesisenIl"; //Kesisenil tablosuna oluşturmuş olduğumuz region ile kesisen illerin alanı ve adını ekliyoruz.
                MapInfoClass.Instance.Do(query3);
                string kesisenIlCount = MapInfoClass.Instance.Eval("tableinfo(kesisenIl, 8)"); //Kesisen il sayısını öğrendik.

                if (kesisenIlCount != "0")
                {
                    MapInfoClass.Instance.Do("fetch first from kesisenIl");
                    maden_Ocagi.Kesisim_Listesi = new List<Kesisim>(); //kesisim listesini başlattık. 
                    for (int i = 0; i < Convert.ToInt32(kesisenIlCount); i++)
                    {
                        Kesisim kesisim = new Kesisim();  //kesisim itemini olusturduk ve elemanlarını ekliyoruz.
                        kesisim.Id = i + 1;
                        kesisim.Kesisim_Alan = Convert.ToDouble(MapInfoClass.Instance.Eval("kesisenIl.Alan").Replace(".", ","));
                        kesisim.Kesisim_Il = MapInfoClass.Instance.Eval("kesisenIl.Il_Adi");
                        MapInfoClass.Instance.Do("o2=kesisenIl.obj");
                        Nokta nokta = new Nokta();
                        nokta.Pointx = Convert.ToDouble(MapInfoClass.Instance.Eval("CentroidX(Overlap(o2,o))").Replace(".", ","));
                        nokta.Pointy = Convert.ToDouble(MapInfoClass.Instance.Eval("CentroidY(Overlap(o2,o))").Replace(".", ","));
                        kesisim.Kesisen_Merkez_Nokta = nokta;
                        maden_Ocagi.Kesisim_Listesi.Add(kesisim);
                        MapInfoClass.Instance.Do("fetch next from kesisenIl");
                    }
                    maden_Ocagi.Il = maden_Ocagi.Kesisim_Listesi.OrderByDescending(x => x.Kesisim_Alan).Select(x => x.Kesisim_Il).FirstOrDefault();
                    maden_Ocagi.Kapladigi_Alan = maden_Ocagi.Kesisim_Listesi.Sum(x => x.Kesisim_Alan);
                    if (islem == "Add")
                    {
                        MapInfoClass.Instance.Do("update Maden_Ocagi set Id=\"" + Convert.ToInt32(rowid) + "\", Alan=\"" + maden_Ocagi.Kapladigi_Alan + "\", Il=\"" + maden_Ocagi.Il + "\" where rowid=" + rowid);
                        MapInfoClass.Instance.Do("commit table Maden_Ocagi");

                    }

                }
                else
                {
                    MessageBox.Show("Haritada kesisen Alan yoktur.");
                }
                return maden_Ocagi;
            }
            catch (Exception e)
            {
                MessageBox.Show("Maden Ocagi olustururken sorun oldu, Bilgiler İşlenemedi.");
                return null;
            }

        }

        /// <summary>
        /// Region oluşturma işlemi.
        /// </summary>
        /// <param name="rowid"></param>
        /// <param name="islem"></param>
        /// <returns></returns>
        public DrawRegion Region(string rowid, string islem)
        {
            DrawRegion region = new DrawRegion();
            MapInfoClass.Instance.Do("select * from region where rowid=" + rowid + " into secim noselect");
            MapInfoClass.Instance.Do("o=secim.obj");
            string query = "select IL_ADI,AREA(Overlap(obj, o), " + '"' + "sq km" + '"' + ") AS " + "\"" + "ALAN" + "\" from iller where obj intersects o into kesisenil2";
            MapInfoClass.Instance.Do(query);
            string query2 = "AREA(o,\"sq km\")";
            region.Alan = Convert.ToDouble(MapInfoClass.Instance.Eval(query2));
            int kesisenCount = Convert.ToInt32(MapInfoClass.Instance.Eval("tableinfo(kesisenil2, 8)"));
            region.alanArr = new List<string>();
            region.sehirArr = new List<string>();
            if (kesisenCount != 0)
            {
                if (islem == "Add")
                {
                    MapInfoClass.Instance.Do("update Region set Id=\"" + Convert.ToInt32(rowid) + "\", Alan=\"" + region.Alan + "\" where rowid=" + rowid);
                    MapInfoClass.Instance.Do("commit table region");

                }

                MapInfoClass.Instance.Do("fetch first from kesisenil2");

                for (int i = 0; i < kesisenCount; i++)
                {

                    region.alanArr.Add(MapInfoClass.Instance.Eval("kesisenil2.ALAN"));
                    region.sehirArr.Add(MapInfoClass.Instance.Eval("kesisenil2.IL_ADI"));


                    MapInfoClass.Instance.Do("fetch next from kesisenil2");
                }

            }
            else
            {
                MessageBox.Show("Haritada kesisen Alan yoktur.");
            }
            return region;
        }

        public Sinir_Duvar SinirDuvarOlustur(string rowid, string islem)
        {
            try
            {
                Sinir_Duvar sinir_Duvar = new Sinir_Duvar();
                MapInfoClass.Instance.Do("dim o2 as object");
                sinir_Duvar.Id = Convert.ToInt32(rowid);
                MapInfoClass.Instance.Do("select * from Sinir_Duvar where rowid=" + rowid + " into secim noselect");
                MapInfoClass.Instance.Do("o=secim.obj");
                string query3 = "select IL_ADI,ObjectLen(Overlap(obj, o), " + '"' + "m" + '"' + ") AS " + "\"" + "UZUNLUK" + "\" from iller where obj intersects o into kesisenIl"; //Kesisenil tablosuna oluşturmuş olduğumuz region ile kesisen illerin alanı ve adını ekliyoruz.
                MapInfoClass.Instance.Do(query3);
                //MapInfoClass.Instance.Do("alter object o info 2, makepen (2,2,16711680)");
                //MapInfoClass.Instance.Do("update secim set obj=o");
                int kesisenIlCount = Convert.ToInt32(MapInfoClass.Instance.Eval("tableinfo(kesisenil, 8)"));

                if (kesisenIlCount != 0)
                {
                    MapInfoClass.Instance.Do("fetch first from kesisenIl");
                    sinir_Duvar.Kesisim_Listesi = new List<KesisimUzunluk>();
                    for (int i = 0; i < kesisenIlCount; i++)
                    {
                        KesisimUzunluk kesisim = new KesisimUzunluk();
                        kesisim.Id = i + 1;
                        kesisim.Kesisim_Uzunluk = Convert.ToDouble(MapInfoClass.Instance.Eval("kesisenIl.UZUNLUK").Replace(".", ","));
                        kesisim.Kesisim_Il = MapInfoClass.Instance.Eval("kesisenIl.Il_Adi");
                        MapInfoClass.Instance.Do("o2=kesisenIl.obj");
                        Nokta nokta = new Nokta();
                        nokta.Pointx = Convert.ToDouble(MapInfoClass.Instance.Eval("CentroidX(Overlap(o2,o))").Replace(".", ","));
                        nokta.Pointy = Convert.ToDouble(MapInfoClass.Instance.Eval("CentroidY(Overlap(o2,o))").Replace(".", ","));
                        kesisim.Kesisen_Merkez_Nokta = nokta;
                        sinir_Duvar.Kesisim_Listesi.Add(kesisim);
                        MapInfoClass.Instance.Do("fetch next from kesisenIl");
                    }
                    sinir_Duvar.Il = sinir_Duvar.Kesisim_Listesi.OrderByDescending(x => x.Kesisim_Uzunluk).Select(x => x.Kesisim_Il).FirstOrDefault();
                    sinir_Duvar.Sinir_Uzunluk = sinir_Duvar.Kesisim_Listesi.Sum(x => x.Kesisim_Uzunluk);
                    if (islem == "Add")
                    {
                        MapInfoClass.Instance.Do("update Sinir_Duvar set Id=\"" + Convert.ToInt32(rowid) + "\", Sınır_Uzunluk=\"" + sinir_Duvar.Sinir_Uzunluk + "\", Il=\"" + sinir_Duvar.Il + "\" where rowid=" + rowid);
                        MapInfoClass.Instance.Do("commit table Sinir_Duvar");

                    }

                }
                else
                {
                    MessageBox.Show("Haritada kesisen Alan yoktur.");
                }

                return sinir_Duvar;
            }
            catch (Exception e)
            {
                MessageBox.Show("Sinir Duvar olustururken sorun oldu, Bilgiler İşlenemedi.");
                return null;
            }
        }


        /// <summary>
        /// Objeyegit layer'imize nokta ekleme işlemi.
        /// </summary>
        /// <param name="_nokta"></param>
        public void AddPointShowObjectLayer(Nokta _nokta)
        {
            MapInfoClass.Instance.Do("insert into OBJEYEGIT (obj) values (CreatePoint(" + _nokta.Pointx.ToString().Replace(",", ".") + "," + _nokta.Pointy.ToString().Replace(",", ".") + "))"); //katmanımıza ekledik pointimizi.
        }

        /// <summary>
        /// Objeyegit katmanımızı temizleme işlemi. 
        /// </summary>
        public void ClearShowObjectLayer()
        {
            MapInfoClass.Instance.Do("rollback table OBJEYEGIT");
        }

        /// <summary>
        /// Objeyegit layerimizde objeye zoom işlemi. 
        /// </summary>
        /// <param name="WindowId"></param>
        public void ZoomToShowLayer(string WindowId)
        {
            MapInfoClass.Instance.Do("Set Map Window" + '"' + WindowId + '"' + "Zoom Entire Layer OBJEYEGIT"); //Objeye zoom işlemi.

        }
    }
}
