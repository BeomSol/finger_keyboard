using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Polling
{
    static class TComm
    {
        public static bool SendText(SerialPort serialPort, string talk)
        {
            // 수신버퍼청소
            string dum = SPort.Read(serialPort);
            
            // 명령송신
            string st = SPort.sSTX() + "TX" + talk + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.2) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 == 3)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "TX")
                    {
                        success = true;
                        break;
                    }
                }
            }
            return success;
        }

        //===========================================================
        //  통신에 성공하면 true 리턴
        //===========================================================
        public static bool RecieveText(SerialPort serialPort, ref string answer)
        {

            // 수신버퍼청소
            string dum = SPort.Read(serialPort);

            // 명령송신
            string st = SPort.sSTX() + "AS" + SPort.sETX();
            SPort.Send(serialPort, st);

            // 송신시간기록
            DateTime stime = DateTime.Now;

            // 수신대기
            int idx1, idx2;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.1) return false;

                // 수신버퍼검사
                rbuff += SPort.Read(serialPort);

                idx1 = rbuff.IndexOf(SPort.sACK());
                idx2 = rbuff.IndexOf(SPort.sETX());

                if (idx1 >= 0 && idx2 - idx1 >= 4)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "AS")
                    {
                        // 한 개의 block 찾음
                        answer = rbuff.Substring(idx1 + 3, idx2-idx1-3);
                        success = true;
                        break;
                    }
                }
            }
            return success;
        }
    }
}
