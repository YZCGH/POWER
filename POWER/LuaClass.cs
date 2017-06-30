using System;
using System.Collections.Generic;
using System.Text;
using LuaInterface;
using System.Windows.Forms;

namespace POWER
{
    class LuaClass
    {
        string sLuaRunFile = "..//..//lua//Run.lua";  //定义初始运行脚本路径
        string sFileLibPath = "..//..//lua//lib//utils_file.lua"; //定义文件操作库脚本路径
        string sPcLibPath = "..//..//lua//lib//utils_pc.lua";  //定义电脑操作库脚本路径
        string sSetingConfigPath = "..//..//lua//setingconfig.lua";//定义设置中的配置文件
        string sOperTypePath = "..//..//lua//opertype.lua";//定义设置中的配置文件

        public Lua m_lua = null;//创建lua的虚拟机
        Object[] RunResult;

        //运行脚本
        public object[] LuaRun(int sOperType)
        {
            //初始化lua
            LuaInit();
            ReadLuaFile(sLuaRunFile);
            //运行RUN.lua脚本的Run函数
            try
            {
                RunResult = m_lua.GetFunction("Run").Call(sOperType);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("运行run脚本文件失败，ErrInfo:{0}", e));
            }


            //删除lua虚拟机
            LuaEnd();

            return RunResult;
        }

        public void LuaInit()
        {
            m_lua = new Lua();//实例化lua虚拟机
            
            //加载库脚本
            ReadLuaFile(sFileLibPath);
            ReadLuaFile(sPcLibPath);
            ReadLuaFile(sSetingConfigPath);
            ReadLuaFile(sOperTypePath);
        }

        //lua加载脚本文件
        public void ReadLuaFile(string sFilePath)
        {

            //加载脚本
            try
            {
                m_lua.DoFile(sFilePath);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("加载脚本文件{0}失败,ErrInfo:{1}", sFilePath, e));
            }

        }

        //调用脚本结束时调用次函数
        public void LuaEnd()
        {
           m_lua.Dispose();
        }

    }

}
