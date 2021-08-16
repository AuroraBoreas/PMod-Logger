"""
^ this module is to classify source files base on pmod_names

@ it has the following functionalities.
- enumerate source files from a given folder (GUI?)
- analyze file name: extract pmod_name, MURA or CUC
- create root directory for the pmod, create sub directories(MURA, CUC)
- copy source files to destination directories


@ changelog
- v0.01, initial build

@ about
- @ZL, 20210816

"""
import shutil, os, logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s %(message)s')
from typing import NewType, TypeVar, Tuple, Union
Dir = NewType('Dir', str)
T   = TypeVar('T', str, None)

class Dispatcher:
    dir_mura = 'MURA'
    dir_cuc  = 'CUC'

    def __init__(self, src:Dir, dst:Dir):
        self._src = src
        self._dst = dst

    def __repr__(self)->str:
        return 'Dispatcher: {} -> {}'.format(self._src, self._dst)

    def __create_dirs(self, pmod:str)->None:
        """[summary]

        :param pmod: [description]
        :type pmod: str
        :return: [description]
        :rtype: Dir
        """
        root = os.path.join(self._dst, pmod)
        if not os.path.exists(root):
            os.mkdir(root)
        subdir_mura = os.path.join(root, self.dir_mura)
        if not os.path.exists(subdir_mura):
            os.mkdir(subdir_mura)
        subdir_cuc  = os.path.join(root, self.dir_cuc)
        if not os.path.exists(subdir_cuc):
            os.mkdir(subdir_cuc)

    def __parse_fname(self, fname:str)->Union[None,Tuple[str]]:
        """[summary] 
        Eep_A5032151A_12225_CUC_20210731155714.eep
        Eep_A5032151A_12225_Mura_20210731155639.eep

        :param fname: [description]
        :type fname: str
        :return: [description]
        :rtype: str
        """
        _ext = '.eep'
        _sep = '_'
        _cnt = 4
        idx_pmod_name = 1
        idx_mura_cuc  = 3
        if _ext in fname and fname.count(_sep) == _cnt:
            split_rv  = fname.split(_sep)
            pmod_name = split_rv[idx_pmod_name]
            mura_cuc  = split_rv[idx_mura_cuc]
            return pmod_name, mura_cuc
        return None

    def work(self)->None:
        """[summary]
        """
        # cnt = 0
        for root, _, files in os.walk(self._src):
            for file in files:
                rv = self.__parse_fname(file)
                if rv:
                    pmod_name, mura_cuc = rv
                    self.__create_dirs(pmod_name)
                    tmp_dir = os.path.join(self._dst, pmod_name, mura_cuc)
                    logging.info("{} -> {}".format(file, tmp_dir))
                    shutil.copyfile(os.path.join(root, file), os.path.join(tmp_dir, file))
                    # cnt += 1
                    # if cnt > 10: break