using System.IO;
using System.Collections.Generic;

namespace PmodLogger
{
    /// <summary>
    /// this simple module is to classify SSVE PMod Mura CUC files
    /// v0.01 @ZL, 20210816
    /// v0.02 @ZL, 20210819. add more constraints to filter fill names
    /// </summary>
    class Dispatcher
    {
        private const string dir_mura = "MURA";
        private const string dir_cuc = "CUC";
        private readonly string _src, _dst;

        public Dispatcher(string src, string dst)
        {
            this._src = src;
            this._dst = dst;
        }

        private static (string, string) ParseFilename(string fname)
        {
            string _sep = "_", mc = "muraresult", cuc = "cucresult";
            int idx_pmod_name = 1;
            int idx_mura_cuc = 3;

            if(fname.ToLower().Contains(mc) || fname.ToLower().Contains(cuc))
            {
                return (string.Empty, string.Empty);
            }
            else
            {
                string[] source = fname.Split(_sep);
                string pmod_name = source[idx_pmod_name];
                string mura_or_cuc = source[idx_mura_cuc];
                return (pmod_name, mura_or_cuc);
            }
        }
        private void CreateDirs(string pmod_name)
        {
            string root = Path.Join(this._dst, pmod_name);
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string subdir_mura = Path.Join(root, dir_mura);
            if(!Directory.Exists(subdir_mura))
            {
                Directory.CreateDirectory(subdir_mura);
            }
            string subdir_cuc = Path.Join(root, dir_cuc);
            if(!Directory.Exists(subdir_cuc))
            {
                Directory.CreateDirectory(subdir_cuc);
            }
        }

        public List<string> Work()
        {
            string[] files = Directory.GetFiles(this._src, "*.eep", SearchOption.AllDirectories);
            List<string> rv = new();
            (string pmod_name, string mura_or_cuc) t1;
            string fName, dstFile, dstDir;
            foreach(string file in files)
            {
                fName = Path.GetFileName(file);
                t1 = ParseFilename(fName);
                if(t1.pmod_name != string.Empty && t1.mura_or_cuc != string.Empty)
                {
                    CreateDirs(t1.pmod_name);
                    dstDir = Path.Join(this._dst, t1.pmod_name, t1.mura_or_cuc);
                    rv.Add(fName);
                    dstFile = Path.Combine(dstDir, fName);
                    File.Copy(file, dstFile, true);
                }
            }
            return rv;
        }
    }
}
