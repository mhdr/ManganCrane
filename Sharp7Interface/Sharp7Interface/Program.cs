using System;
using Sharp7;

namespace Sharp7Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            S7Client client = new S7Client();
            int result = client.ConnectTo("192.168.0.2", 0, 2);

            if (result != 0)
            {
                Console.WriteLine(client.ErrorText(result));
            }
            else
            {
                byte[] dbBuffer = new byte[56];
                result = client.DBRead(220, 0, 56, dbBuffer);

                if (result != 0)
                {
                    Console.WriteLine(client.ErrorText(result));
                }
                else
                {
                    // wight of load
                    var load = S7.GetDWordAt(dbBuffer, 0);
                    PrintDWord("wight of load", load, 0);

                    // baad sanj
                    var anemometer = S7.GetDWordAt(dbBuffer, 4);
                    PrintDWord("baad sanj", anemometer, 4);

                    // zaveye sanj
                    var angelmeter = S7.GetDWordAt(dbBuffer, 8);
                    PrintDWord("zaveye sanj", angelmeter, 8);

                    // current meter
                    var current = S7.GetDWordAt(dbBuffer, 12);
                    PrintDWord("current meter", current, 12);

                    // volt metr
                    var volltage = S7.GetDWordAt(dbBuffer, 16);
                    PrintDWord("volt metr", volltage, 16);

                    // crain act time
                    var cat = S7.GetDWordAt(dbBuffer, 20);
                    PrintDWord("crain act time", cat, 20);

                    // hoest active time
                    var hat = S7.GetDWordAt(dbBuffer, 24);
                    PrintDWord("hoest active time", hat, 24);

                    // luffing active time
                    var lat = S7.GetDWordAt(dbBuffer, 28);
                    PrintDWord("luffing active time", lat, 28);

                    // slewing active time
                    var sat = S7.GetDWordAt(dbBuffer, 32);
                    PrintDWord("slewing active time", sat, 32);

                    // traveling active time
                    var tat = S7.GetDWordAt(dbBuffer, 36);
                    PrintDWord("traveling active time", tat, 36);

                    // frecunce
                    var fr = S7.GetDWordAt(dbBuffer, 40);
                    PrintDWord("frecunce", fr, 40);

                    //////////////////////////////////////////////////

                    // unloading
                    var unl = S7.GetBitAt(dbBuffer, 44, 0);
                    PrintBit("unloading", unl, 44, 0);

                    // loading
                    var lod = S7.GetBitAt(dbBuffer, 44, 1);
                    PrintBit("loading", lod, 44, 1);

                    // roll
                    var roll = S7.GetBitAt(dbBuffer, 44, 2);
                    PrintBit("roll", roll, 44, 2);

                    // slab
                    var slb = S7.GetBitAt(dbBuffer, 44, 3);
                    PrintBit("slab", slb, 44, 3);

                    // maftool
                    var mft = S7.GetBitAt(dbBuffer, 44, 4);
                    PrintBit("maftool", mft, 44, 4);

                    // grab
                    var grb = S7.GetBitAt(dbBuffer, 44, 5);
                    PrintBit("grab", grb, 44, 5);

                    // takhteh
                    var tak = S7.GetBitAt(dbBuffer, 44, 6);
                    PrintBit("takhteh", tak, 44, 6);

                    // shemsh
                    var shm = S7.GetBitAt(dbBuffer, 44, 7);
                    PrintBit("shemsh", shm, 44, 7);

                    //////////////////////////////////////////////////

                    // milgerd
                    var mil = S7.GetBitAt(dbBuffer, 45, 0);
                    PrintBit("milgerd", mil, 45, 0);

                    // negle
                    var neg = S7.GetBitAt(dbBuffer, 45, 1);
                    PrintBit("negle", neg, 45, 1);

                    // main phaze control
                    var mpc = S7.GetBitAt(dbBuffer, 45, 2);
                    PrintBit("main phaze control", mpc, 45, 2);

                    // power supply fuze 1
                    var psf1 = S7.GetBitAt(dbBuffer, 45, 3);
                    PrintBit("power supply fuze 1", psf1, 45, 3);

                    // power supply fuse 2
                    var psf2 = S7.GetBitAt(dbBuffer, 45, 4);
                    PrintBit("power supply fuse 2", psf2, 45, 4);

                    // north east emergency on chasis
                    var neems = S7.GetBitAt(dbBuffer, 45, 5);
                    PrintBit("north east emergency on chasis", neems, 45, 5);

                    // south east emergency on chasis
                    var seems = S7.GetBitAt(dbBuffer, 45, 6);
                    PrintBit("south east emergency on chasis", seems, 45, 6);

                    // north west emergency on chasis
                    var nwes = S7.GetBitAt(dbBuffer, 45, 7);
                    PrintBit("north west emergency on chasis", nwes, 45, 7);

                    //////////////////////////////////////////////////

                    // south west emergency on chasis
                    var swes = S7.GetBitAt(dbBuffer, 46, 0);
                    PrintBit("south west emergency on chasis", swes, 46, 0);

                    // engine room emergency
                    var eres = S7.GetBitAt(dbBuffer, 46, 1);
                    PrintBit("engine room emergency", eres, 46, 1);

                    // operation console emergency
                    var oces = S7.GetBitAt(dbBuffer, 46, 2);
                    PrintBit("operation console emergency", oces, 46, 2);

                    // hoist drive situation
                    var hs = S7.GetBitAt(dbBuffer, 46, 3);
                    PrintBit("hoist drive situation", hs, 46, 3);

                    // luffing drive situation
                    var ls = S7.GetBitAt(dbBuffer, 46, 4);
                    PrintBit("luffing drive situation", ls, 46, 4);

                    // slewing drive situation
                    var ss = S7.GetBitAt(dbBuffer, 46, 5);
                    PrintBit("slewing drive situation", ss, 46, 5);

                    // circuite braker of hoist brake
                    var qhb = S7.GetBitAt(dbBuffer, 46, 6);
                    PrintBit("circuite braker of hoist brake", qhb, 46, 6);

                    // ciecuite braker of luffing brake
                    var qlb = S7.GetBitAt(dbBuffer, 46, 7);
                    PrintBit("ciecuite braker of luffing brake", qlb, 46, 7);

                    //////////////////////////////////////////////////

                    // over temp of hoist
                    var tshm = S7.GetBitAt(dbBuffer, 47, 0);
                    PrintBit("over temp of hoist", tshm, 47, 0);

                    // over temp of luffing
                    var tslm = S7.GetBitAt(dbBuffer, 47, 1);
                    PrintBit("over temp of luffing", tslm, 47, 1);

                    // over temp of slewing 1
                    var tsssm1 = S7.GetBitAt(dbBuffer, 47, 2);
                    PrintBit("over temp of slewing 1", tsssm1, 47, 2);

                    // over temp of slewing 2
                    var tssm2 = S7.GetBitAt(dbBuffer, 47, 3);
                    PrintBit("over temp of slewing 2", tssm2, 47, 3);

                    // end movement of luffing_in
                    var end_in_l = S7.GetBitAt(dbBuffer, 47, 4);
                    PrintBit("end movement of luffing_in", end_in_l, 47, 4);

                    // end movment of luffing_ out
                    var end_out_l = S7.GetBitAt(dbBuffer, 47, 5);
                    PrintBit("end movment of luffing_ out", end_out_l, 47, 5);

                    // end movement of hoist_top
                    var end_top_h = S7.GetBitAt(dbBuffer, 47, 6);
                    PrintBit("end movement of hoist_top", end_top_h, 47, 6);

                    // end movement of hoist_ low(sea side)
                    var end_low_h = S7.GetBitAt(dbBuffer, 47, 7);
                    PrintBit("end movement of hoist_ low(sea side)", end_low_h, 47, 7);

                    //////////////////////////////////////////////////

                    // circuet braker of slewing 1 brake
                    var qbs1 = S7.GetBitAt(dbBuffer, 48, 0);
                    PrintBit("circuet braker of slewing 1 brake", qbs1, 48, 0);

                    // circuet braker of slewing 2 brake
                    var qbs2 = S7.GetBitAt(dbBuffer, 48, 1);
                    PrintBit("circuet braker of slewing 2 brake", qbs2, 48, 1);

                    // circuet braker of cable real motor
                    var qcrm = S7.GetBitAt(dbBuffer, 48, 2);
                    PrintBit("circuet braker of cable real motor", qcrm, 48, 2);

                    // circuet braker of cable real fan
                    var qcrf = S7.GetBitAt(dbBuffer, 48, 3);
                    PrintBit("circuet braker of cable real fan", qcrf, 48, 3);

                    // cercuit braker of north east traveling brake
                    var neqbt = S7.GetBitAt(dbBuffer, 48, 4);
                    PrintBit("cercuit braker of north east traveling brake", neqbt, 48, 4);

                    // cercuit braker of south east traveling brake
                    var seqbt = S7.GetBitAt(dbBuffer, 48, 5);
                    PrintBit("cercuit braker of south east traveling brake", seqbt, 48, 5);

                    // cercuit braker of north west traveling brake
                    var nwqbt = S7.GetBitAt(dbBuffer, 48, 6);
                    PrintBit("cercuit braker of north west traveling brake", nwqbt, 48, 6);

                    // cercuit braker of south west traveling brake
                    var swqbt = S7.GetBitAt(dbBuffer, 48, 7);
                    PrintBit("cercuit braker of south west traveling brake", swqbt, 48, 7);

                    //////////////////////////////////////////////////

                    // north limit switch of cable real
                    var crls1 = S7.GetBitAt(dbBuffer, 49, 0);
                    PrintBit("north limit switch of cable real", crls1, 49, 0);

                    // south limit switch of cable real
                    var crls2 = S7.GetBitAt(dbBuffer, 49, 1);
                    PrintBit("south limit switch of cable real", crls2, 49, 1);

                    // fuze of engine room fan
                    var erff = S7.GetBitAt(dbBuffer, 49, 2);
                    PrintBit("fuze of engine room fan", erff, 49, 2);

                    // fuse of lighting sistem
                    var lf = S7.GetBitAt(dbBuffer, 49, 3);
                    PrintBit("fuse of lighting sistem", lf, 49, 3);

                    // end of movement of hoist in lowering in shore side
                    var erhjl = S7.GetBitAt(dbBuffer, 49, 4);
                    PrintBit("end of movement of hoist in lowering in shore side", erhjl, 49, 4);

                    // luffing is low speed
                    var lls = S7.GetBitAt(dbBuffer, 49, 5);
                    PrintBit("luffing is low speed", lls, 49, 5);

                    // main switch of hoist
                    var msh = S7.GetBitAt(dbBuffer, 49, 6);
                    PrintBit("main switch of hoist", msh, 49, 6);

                    // main switch of luffing
                    var msl = S7.GetBitAt(dbBuffer, 49, 7);
                    PrintBit("main switch of luffing", msl, 49, 7);

                    //////////////////////////////////////////////////

                    // main switch of slewing
                    var mss = S7.GetBitAt(dbBuffer, 50, 0);
                    PrintBit("main switch of slewing", mss, 50, 0);

                    // main switch of traveling
                    var mst = S7.GetBitAt(dbBuffer, 50, 1);
                    PrintBit("main switch of traveling", mst, 50, 1);

                    // operation mode
                    var om = S7.GetBitAt(dbBuffer, 50, 2);
                    PrintBit("operation mode", om, 50, 2);

                    // test mode
                    var tm = S7.GetBitAt(dbBuffer, 50, 3);
                    PrintBit("test mode", tm, 50, 3);

                    // main control contactor
                    var mcc = S7.GetBitAt(dbBuffer, 50, 4);
                    PrintBit("main control contactor", mcc, 50, 4);

                    // sensor of slewing location
                    var ssl = S7.GetBitAt(dbBuffer, 50, 5);
                    PrintBit("sensor of slewing location", ssl, 50, 5);

                    // storm brake east
                    var sbe = S7.GetBitAt(dbBuffer, 50, 6);
                    PrintBit("storm brake east", sbe, 50, 6);

                    // storm brake west
                    var sbw = S7.GetBitAt(dbBuffer, 50, 7);
                    PrintBit("storm brake west", sbw, 50, 7);

                    //////////////////////////////////////////////////

                    // interlock is activate
                    var ia = S7.GetBitAt(dbBuffer, 51, 0);
                    PrintBit("interlock is activate", ia, 51, 0);

                    // main power contactor
                    var mc = S7.GetBitAt(dbBuffer, 51, 1);
                    PrintBit("main power contactor", mc, 51, 1);

                    // LOW SPEED OF HOIST
                    var LSH = S7.GetBitAt(dbBuffer, 51, 2);
                    PrintBit("LOW SPEED OF HOIST", LSH, 51, 2);

                    // BRAKE OF LUFFING
                    var BL = S7.GetBitAt(dbBuffer, 51, 3);
                    PrintBit("BRAKE OF LUFFING", BL, 51, 3);

                    // BRAKE OF HOIST
                    var BH = S7.GetBitAt(dbBuffer, 51, 4);
                    PrintBit("BRAKE OF HOIST", BH, 51, 4);

                    // BRAKE OF SLEWING 1
                    var BS1 = S7.GetBitAt(dbBuffer, 51, 5);
                    PrintBit("BRAKE OF SLEWING 1", BS1, 51, 5);

                    // BRAKE OF SLEWING 2
                    var BS2 = S7.GetBitAt(dbBuffer, 51, 6);
                    PrintBit("BRAKE OF SLEWING 2", BS2, 51, 6);

                    // MOVEMENT IN HOIST JOYSTICK
                    var MHJ = S7.GetBitAt(dbBuffer, 51, 7);
                    PrintBit("MOVEMENT IN HOIST JOYSTICK", MHJ, 51, 7);

                    //////////////////////////////////////////////////

                    // MOVEMENT IN LUFFING JOYSTICK
                    var MLJ = S7.GetBitAt(dbBuffer, 52, 0);
                    PrintBit("MOVEMENT IN LUFFING JOYSTICK", MLJ, 52, 0);

                    // MOVEMENT IN SLEWING JOYSTICK
                    var MSJ = S7.GetBitAt(dbBuffer, 52, 1);
                    PrintBit("MOVEMENT IN SLEWING JOYSTICK", MSJ, 52, 1);

                    // MOVEMENT IN TRAVELING JOYSTICK
                    var MTJ = S7.GetBitAt(dbBuffer, 52, 2);
                    PrintBit("MOVEMENT IN TRAVELING JOYSTICK", MTJ, 52, 2);

                    // BRAKE OF TRAVELING
                    var BT = S7.GetBitAt(dbBuffer, 52, 3);
                    PrintBit("BRAKE OF TRAVELING", BT, 52, 3);

                    // end of cable real
                    var ecr = S7.GetBitAt(dbBuffer, 52, 4);
                    PrintBit("end of cable real", ecr, 52, 4);

                    // expert 1 set
                    var exp1 = S7.GetBitAt(dbBuffer, 52, 5);
                    PrintBit("expert 1 set", exp1, 52, 5);

                    // expert 2 set
                    var exp2 = S7.GetBitAt(dbBuffer, 52, 6);
                    PrintBit("expert 2 set", exp2, 52, 6);

                    // expert 3 set
                    var exp3 = S7.GetBitAt(dbBuffer, 52, 7);
                    PrintBit("expert 3 set", exp3, 52, 7);

                    //////////////////////////////////////////////////

                    // expert 4 set
                    var exp4 = S7.GetBitAt(dbBuffer, 53, 0);
                    PrintBit("expert 4 set", exp4, 53, 0);

                    // expert 5 set
                    var exp5 = S7.GetBitAt(dbBuffer, 53, 1);
                    PrintBit("expert 5 set", exp5, 53, 1);

                    // expert 6 set
                    var exp6 = S7.GetBitAt(dbBuffer, 53, 2);
                    PrintBit("expert 6 set", exp6, 53, 2);

                    // expert 7 set
                    var exp7 = S7.GetBitAt(dbBuffer, 53, 3);
                    PrintBit("expert 7 set", exp7, 53, 3);

                    // expert 8 set
                    var exp8 = S7.GetBitAt(dbBuffer, 53, 4);
                    PrintBit("expert 8 set", exp8, 53, 4);

                    // operator 1 set
                    var opr1 = S7.GetBitAt(dbBuffer, 53, 5);
                    PrintBit("operator 1 set", opr1, 53, 5);

                    // operator 2 set
                    var opr2 = S7.GetBitAt(dbBuffer, 53, 6);
                    PrintBit("operator 2 set", opr2, 53, 6);

                    // operator 3 set
                    var opr3 = S7.GetBitAt(dbBuffer, 53, 7);
                    PrintBit("operator 3 set", opr3, 53, 7);

                    //////////////////////////////////////////////////

                    // operator 4 set
                    var opr4 = S7.GetBitAt(dbBuffer, 54, 0);
                    PrintBit("operator 4 set", opr4, 54, 0);

                    // operator 5 set
                    var opr5 = S7.GetBitAt(dbBuffer, 54, 1);
                    PrintBit("operator 5 set", opr5, 54, 1);

                    // operator 6 set
                    var opr6 = S7.GetBitAt(dbBuffer, 54, 2);
                    PrintBit("operator 6 set", opr6, 54, 2);

                    // operator 7 set
                    var opr7 = S7.GetBitAt(dbBuffer, 54, 3);
                    PrintBit("operator 7 set", opr7, 54, 3);

                    // operator 8 set
                    var opr8 = S7.GetBitAt(dbBuffer, 54, 4);
                    PrintBit("operator 8 set", opr8, 54, 4);

                    // operator 9 set
                    var opr9 = S7.GetBitAt(dbBuffer, 54, 5);
                    PrintBit("operator 9 set", opr9, 54, 5);

                    // operator 10 set
                    var opr10 = S7.GetBitAt(dbBuffer, 54, 6);
                    PrintBit("operator 10 set", opr10, 54, 6);

                    // operator 11 set
                    var opr11 = S7.GetBitAt(dbBuffer, 54, 7);
                    PrintBit("operator 11 set", opr11, 54, 7);

                    //////////////////////////////////////////////////

                    // operator 12 set
                    var opr12 = S7.GetBitAt(dbBuffer, 55, 0);
                    PrintBit("operator 12 set", opr12, 55, 0);
                }
            }
        }

        static void PrintBit(string msg, bool value, int pos, int bit)
        {
            Console.WriteLine($@"DB 220 DBX {pos}.{bit} => {msg} : {value}");
        }

        static void PrintDWord(string msg, uint value, int pos)
        {
            Console.WriteLine($@"DB 220 DBD {pos} => {msg} : {value}");
        }
    }
}