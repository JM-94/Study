using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Car
    {
        public Car(string 경도, string 사용전력량, string 사용횟수, string 위도, string 일자, string 충전기ID, string 충전기타입, string 충전소ID, string 충전소명칭)
        {
            this.경도 = 경도;
            this.사용전력량 = 사용전력량;
            this.사용횟수 = 사용횟수;
            this.위도 = 위도;
            this.일자 = 일자;
            this.충전기ID = 충전기ID;
            this.충전기타입 = 충전기타입;
            this.충전소ID = 충전소ID;
            this.충전소명칭 = 충전소명칭;


        }

        public string 경도 { get; set; }
        public string 사용전력량 { get; set; }
        public string 사용횟수 { get; set; }
        public string 위도 { get; set; }
        public string 일자 { get; set; }
        public string 충전기ID { get; set; }
        public string 충전기타입 { get; set; }
        public string 충전소ID { get; set; }
        public string 충전소명칭 { get; set; }
    }
}
