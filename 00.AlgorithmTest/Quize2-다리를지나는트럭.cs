using System;
using System.Collections.Generic;
using System.Text;


/*
 * 

문제 설명
트럭 여러 대가 강을 가로지르는 일 차선 다리를 정해진 순으로 건너려 합니다. 모든 트럭이 다리를 건너려면 최소 몇 초가 걸리는지 알아내야 합니다. 
트럭은 1초에 1만큼 움직이며, 다리 길이는 bridge_length이고 다리는 무게 weight까지 견딥니다.
※ 트럭이 다리에 완전히 오르지 않은 경우, 이 트럭의 무게는 고려하지 않습니다.

예를 들어, 길이가 2이고 10kg 무게를 견디는 다리가 있습니다. 무게가 [7, 4, 5, 6]kg인 트럭이 순서대로 최단 시간 안에 다리를 건너려면 다음과 같이 건너야 합니다.

경과 시간	다리를 지난 트럭	다리를 건너는 트럭	대기 트럭
0	[]	        []	    [7,4,5,6]
1~2	[]	        [7]	    [4,5,6]
3	[7]	        [4]	    [5,6]
4	[7]	        [4,5]	[6]
5	[7,4]	    [5]	    [6]
6~7	[7,4,5]	    [6]	    []
8	[7,4,5,6]	[]	    []

따라서, 모든 트럭이 다리를 지나려면 최소 8초가 걸립니다.

solution 함수의 매개변수로 다리 길이 bridge_length, 다리가 견딜 수 있는 무게 weight, 트럭별 무게 truck_weights가 주어집니다. 이때 모든 트럭이 다리를 건너려면 최소 몇 초가 걸리는지 return 하도록 solution 함수를 완성하세요.

제한 조건
bridge_length는 1 이상 10,000 이하입니다.
weight는 1 이상 10,000 이하입니다.
truck_weights의 길이는 1 이상 10,000 이하입니다.
모든 트럭의 무게는 1 이상 weight 이하입니다.

입출력 예
bridge_length	weight	truck_weights	return
2	            10	    [7,4,5,6]	    8
100	            100	    [10]	        101
100	            100	    [10,10,10,10,10,10,10,10,10,10]	110
출처
 * 
 * 
 * 
 * 
 * public int solution(int bridge_length, int weight, int[] truck_weights) {
        Queue<int> que = new Queue<int>();
            int time = 0, count = 0, bridge = 0;

            while (count < truck_weights.Length)
            {
                if (que.Count == bridge_length)
                {
                    bridge -= que.Dequeue();
                }

                if (bridge + truck_weights[count] <= weight)
                {
                    bridge += truck_weights[count];
                    que.Enqueue(truck_weights[count]);
                    count++;
                }
                else
                {
                    que.Enqueue(0);
                }

                time++;
            }
            time += bridge_length;

            return time;
    }

public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        int answer = 0;

        int index = 0;
        Queue bridge = new Queue();
        bridge.Enqueue(truck_weights[index] + "," + bridge_length);
        int cur_weight = weight - truck_weights[index];
        index++;

        while(bridge.Count != 0)
        {
            answer++;
            int length = bridge.Count;
            for (int i = 0; i < length; i++)
            {
                string[] truck = bridge.Dequeue().ToString().Split(',');
                int count = int.Parse(truck[1]) - 1;
                if (count > 0)
                    bridge.Enqueue(truck[0] + "," + count);
                else
                    cur_weight += int.Parse(truck[0]);
            }

            if(index < truck_weights.Length && cur_weight >= truck_weights[index])
            { 
                bridge.Enqueue(truck_weights[index] + "," + bridge_length);
                cur_weight = cur_weight - truck_weights[index];
                index++;
            }
        }

        return answer + 1;
    }




 * */

namespace _00.AlgorithmTest
{

    class Quize2_다리를지나는트럭
    {



        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;
            int[,] aList = new int[truck_weights.Length, 2];            
            int iRunSum = 0;
            int iRunCar = 0;
            
            List<int> lstTruck = new List<int>();

            // truck배열을 list로 사용하게...
            for (int i = 0; i < truck_weights.Length; i++)
            {
                lstTruck.Add(truck_weights[i]);
            }


            // 이 반복문이 시간이 됨....
            for (int i = 0; i < bridge_length * weight * truck_weights.Length; i++)
            {
                // lstRun에 있는 차는 모두 시간을 증가시킨다.

                // 만약 현재 진행중인 차가 없으면 새차를 넣는다. lstRun에 차 등록
                // 현재 진행중인 차의 무게와 대기차의 무계가 한계를 넘지 않으면 lstRun에 차 추가

                // lstRun에서 시간이 만료한 차는 삭제 한다.

                // lstRun에 진행중인 차가 없고 대기중인 차가 없으면 종료한다. 
                iRunSum = 0;
                iRunCar = 0;

                for (int j = 0; j < aList.GetLength(0); j++)
                {
                    if (aList[j, 0] > 0)
                    {
                        // 시간이 다 된 차량.....뺀다.
                        if (++aList[j, 1] > bridge_length)
                        {
                            aList[j, 0] = 0;        
                            aList[j, 1] = 0;
                        }                        
                    }

                    // 다리에 있는 차가 있는지 체크
                    if (aList[j, 0] > 0)
                    {
                        iRunCar++;
                        iRunSum += aList[j, 0];     // 현재 다리에 있는 차의 무계를 구한다.
                    }
                }

                // 다리와 대기차량이 없으면 종료
                if ( lstTruck.Count == 0 && iRunCar == 0)
                {
                    answer = i;
                    break;
                }

                if (lstTruck.Count > 0 && iRunSum + lstTruck[0] <= weight  )
                {
                    for (int j = 0; j < aList.GetLength(0); j++)
                    {
                        if (aList[j,0] == 0)
                        {
                            aList[j, 0] = lstTruck[0];
                            aList[j, 1]++;
                            lstTruck.RemoveAt(0);
                            break;
                        }
                    }                    
                }
            }

            return ++answer;
        }

        public void Answer()
        {
            Console.WriteLine(solution(2, 10, new int[] {7, 4, 5, 6}));
            Console.WriteLine(solution(100, 100, new int[] { 10 }));
            Console.WriteLine(solution(100, 100, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }));
        }
    }
}
