using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace matrici
{
    class Evaluare
    {
        string compilator, dirComp;
        public Evaluare()
        {
            compilator = @"c:\Program Files (x86)\CodeBlocks\MinGW\bin\g++.exe";
            dirComp = Path.GetTempPath();
        }
        public Evaluare(string comp)
        {
            compilator = comp;
            dirComp = Path.GetTempPath();
        }
        public Evaluare(string comp, string dir)
        {
            compilator = comp;
            dirComp = dir;
        }
        public string Compileaza(string fisier)// nume fisier de compilat, cu tot cu cale
        {
            try
            {
                //sterg fisierul executabil
                File.Delete(dirComp + @"\test2020.exe");
                //File.Copy(fisier, dirComp + @"\" + Path.GetFileName(fisier));
            }
            finally
            {

            }
            // creez pocesul
            Process proc = new Process();
            proc.StartInfo.FileName = compilator;
            proc.StartInfo.Arguments = " " + fisier + " -o " + dirComp + @"\test2020.exe";
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            // pregatesc variabile pt. erori si output
            var erori = new StringBuilder();
            var output = new StringBuilder();
            var hadErrors = false;
            // raise events
            proc.EnableRaisingEvents = true;
            // capturez outputul
            proc.OutputDataReceived += (s, d) => {
                output.Append(d.Data);
            };
            // Capturez erorile
            proc.ErrorDataReceived += (s, d) => {
                if (!hadErrors)
                {
                    hadErrors = !String.IsNullOrEmpty(d.Data);
                }
                erori.Append(d.Data);
            };
            proc.Start();

            // ascult ce returneaza
            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();

            //astept pana se termina procesul
            proc.WaitForExit();
            string stdout = output.ToString();
            string stderr = erori.ToString();

            return stdout + " * " + stderr;
        }
        public string Ruleaza(string fisier)// nume fisier de intrare, cu tot cu cale
        {
            try
            {

                File.Copy(fisier, dirComp + @"\" + Path.GetFileName(fisier));
            }
            catch
            {

            }
            // creez pocesul
            Process proc = new Process();
            proc.StartInfo.FileName = dirComp + @"\test2020.exe";
            proc.StartInfo.Arguments = "";
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // pregatesc variabile pt. erori si output
            var erori = new StringBuilder();
            var output = new StringBuilder();
            var hadErrors = false;

            // raise events
            proc.EnableRaisingEvents = true;

            // capturez outputul
            proc.OutputDataReceived += (s, d) => {
                output.Append(d.Data);
            };

            // Capturez erorile
            proc.ErrorDataReceived += (s, d) => {
                if (!hadErrors)
                {
                    hadErrors = !String.IsNullOrEmpty(d.Data);
                }
                erori.Append(d.Data);
            };

            proc.Start();

            // ascult ce returneaza
            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();

            //astept pana se termina procesul
            proc.WaitForExit(1000);
            try
            {
                proc.Kill();
            }
            catch
            {

            }
            string stdout = output.ToString();
            string stderr = erori.ToString();
            return stdout + " * " + stderr;
        }
        //******************************************************************************************
        //n - nr linii, m - nr. coloane matrice
        public int EvaluareAfisare(string codCorect, string codElev, int n, int m)
        {
            // am generat codul elevului pentru evaluare
            string s = @"#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, s;
int main()
        {
            fin >> n >> m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                    fin >> a[i][j]; 
" + codElev + "" + @"
return 0; }";
            //generez fisierul de test
            // pentru inceput sterg fisierele utilizate la testul anterior
            try { File.Delete(Directory.GetCurrentDirectory() + @"\test.txt"); } catch { };
            try { File.Delete(Directory.GetCurrentDirectory() + @"\codcorect.cpp"); } catch { };
            try { File.Delete(Directory.GetCurrentDirectory() + @"\codelev.cpp"); } catch { };
            // creez un fisier nou ce va contine o matrice cu n linii si m coloane
            Random r = new Random();
            int i, j;
            string l;
            try
            {
                StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\test.txt");
                sw.WriteLine(n.ToString() + " " + m.ToString());
                for (i = 1; i <= n; i++)
                {
                    l = "";
                    for (j = 1; j <= m; j++)
                        l += r.Next(2, 50) + " ";
                    sw.WriteLine(l);
                }
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul de test");
                return 0;
            }
            // creez fisierul cu codul corect
            try
            {
                StreamWriter fisierCodCorect = new StreamWriter(Directory.GetCurrentDirectory() + @"\codcorect.cpp");
                fisierCodCorect.WriteLine(codCorect);
                fisierCodCorect.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul cu codul corect");
                return 0;
            }
            // creez fisierul cu codul elevului
            try
            {
                StreamWriter fisierCodElev = new StreamWriter(Directory.GetCurrentDirectory() + @"\codelev.cpp");
                fisierCodElev.WriteLine(s);
                fisierCodElev.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul cu codul elevului");
                return 0;
            }
            Compileaza("codcorect.cpp");
            string rCorect = Ruleaza("test.txt");
            string rCompilare = Compileaza("codelev.cpp");
            if (rCompilare.Length > 4)
            {
                MessageBox.Show("Posibila eroare de compilare: " + rCompilare);
                return 0;
            }
            string rElev = Ruleaza("test.txt");
            if (rCorect == rElev) return 1;
            else return 0;
        }
        //******************************************************************************************************************
        public int EvaluareGenerare(string codCorect, string codElev, int n, int m, int k)
        {
            // am generat codul elevului pentru evaluare
            string s = @"#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, k;
int main()
        {
            fin >> n >> m >> k;
" + codElev + @"
            for (i = 0; i <= n; i++)
                {for (j = 0; j <= m; j++)
                    cout << a[i][j] << "" "";
                 cout << endl;
                }
return 0; }";
            string sc = @"#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, k;
int main()
        {
            fin >> n >> m >> k;
" + codCorect + @"
            for (i = 0; i <= n; i++)
                {for (j = 0; j <= m; j++)
                    cout << a[i][j] << "" "";
                 cout << endl;
                }
return 0; }";
            //generez fisierul de test
            // pentru inceput sterg fisierele utilizate la testul anterior
            try { File.Delete(Directory.GetCurrentDirectory() + @"\test.txt"); } catch { };
            try { File.Delete(Directory.GetCurrentDirectory() + @"\codcorect.cpp"); } catch { };
            try { File.Delete(Directory.GetCurrentDirectory() + @"\codelev.cpp"); } catch { };
            // creez un fisier nou ce va contine o matrice cu n linii si m coloane
            Random r = new Random();
            int i, j;
            string l;
            try
            {
                StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\test.txt");
                sw.WriteLine(n.ToString() + " " + m.ToString() + " " + k.ToString());
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul de test");
                return 0;
            }
            // creez fisierul cu codul corect
            try
            {
                StreamWriter fisierCodCorect = new StreamWriter(Directory.GetCurrentDirectory() + @"\codcorect.cpp");
                fisierCodCorect.WriteLine(sc);
                fisierCodCorect.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul cu codul corect");
                return 0;
            }
            // creez fisierul cu codul elevului
            try
            {
                StreamWriter fisierCodElev = new StreamWriter(Directory.GetCurrentDirectory() + @"\codelev.cpp");
                fisierCodElev.WriteLine(s);
                fisierCodElev.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul cu codul elevului");
                return 0;
            }
            string rc = Compileaza("codcorect.cpp");
            string rCorect = Ruleaza("test.txt");

            string rCompilare = Compileaza("codelev.cpp");
            if (rCompilare.Length > 4)
            {
                MessageBox.Show("Posibila eroare de compilare: " + rCompilare);
                return 0;
            }
            string rElev = Ruleaza("test.txt");
            if (rCorect == rElev) return 1;
            else return 0;
        }

            //******************************************************************************************************************
            public int EvaluareGenerare2(string codCorect, string codElev, int n, int m, int k)
        {
            // am generat codul elevului pentru evaluare
            string s = @"#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, k;
int main()
        {
            fin >> n >> m >> k;
            for(i=0;i<n;i++)
                for(j=0;j<m;j++)
" + codElev + @"
            for (i = 0; i <= n; i++)
                {for (j = 0; j <= m; j++)
                    cout << a[i][j] << "" "";
                 cout << endl;
                }
return 0; }";
            string sc = @"#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, k;
int main()
        {
            fin >> n >> m >> k;
            for(i=0;i<n;i++)
                for(j=0;j<m;j++)
" + codCorect + @"
            for (i = 0; i <= n; i++)
                {for (j = 0; j <= m; j++)
                    cout << a[i][j] << "" "";
                 cout << endl;
                }
return 0; }";
            //generez fisierul de test
            // pentru inceput sterg fisierele utilizate la testul anterior
            try { File.Delete(Directory.GetCurrentDirectory() + @"\test.txt"); } catch { };
            try { File.Delete(Directory.GetCurrentDirectory() + @"\codcorect.cpp"); } catch { };
            try { File.Delete(Directory.GetCurrentDirectory() + @"\codelev.cpp"); } catch { };
            // creez un fisier nou ce va contine o matrice cu n linii si m coloane
            Random r = new Random();
            int i, j;
            string l;
            try
            {
                StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\test.txt");
                sw.WriteLine(n.ToString() + " " + m.ToString() + " " + k.ToString());
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul de test");
                return 0;
            }
            // creez fisierul cu codul corect
            try
            {
                StreamWriter fisierCodCorect = new StreamWriter(Directory.GetCurrentDirectory() + @"\codcorect.cpp");
                fisierCodCorect.WriteLine(sc);
                fisierCodCorect.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul cu codul corect");
                return 0;
            }
            // creez fisierul cu codul elevului
            try
            {
                StreamWriter fisierCodElev = new StreamWriter(Directory.GetCurrentDirectory() + @"\codelev.cpp");
                fisierCodElev.WriteLine(s);
                fisierCodElev.Close();
            }
            catch
            {
                MessageBox.Show("Nu am reușit să creez fișierul cu codul elevului");
                return 0;
            }
            string rc = Compileaza("codcorect.cpp");
            string rCorect = Ruleaza("test.txt");

            string rCompilare = Compileaza("codelev.cpp");
            if (rCompilare.Length > 4)
            {
                MessageBox.Show("Posibila eroare de compilare: " + rCompilare);
                return 0;
            }
            string rElev = Ruleaza("test.txt");
            if (rCorect == rElev) return 1;
            else return 0;
        }
        

    }
}

