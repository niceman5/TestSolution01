﻿using System;
using System.Collections.Generic;
using System.Text;

/*
 * 문제 설명
선행 스킬이란 어떤 스킬을 배우기 전에 먼저 배워야 하는 스킬을 뜻합니다.

예를 들어 선행 스킬 순서가 스파크 → 라이트닝 볼트 → 썬더일때, 썬더를 배우려면 먼저 라이트닝 볼트를 배워야 하고, 라이트닝 볼트를 배우려면 먼저 스파크를 배워야 합니다.

위 순서에 없는 다른 스킬(힐링 등)은 순서에 상관없이 배울 수 있습니다. 따라서 스파크 → 힐링 → 라이트닝 볼트 → 썬더와 같은 스킬트리는 가능하지만, 썬더 → 스파크나 라이트닝 볼트 → 스파크 → 힐링 → 썬더와 같은 스킬트리는 불가능합니다.

선행 스킬 순서 skill과 유저들이 만든 스킬트리1를 담은 배열 skill_trees가 매개변수로 주어질 때, 가능한 스킬트리 개수를 return 하는 solution 함수를 작성해주세요.

제한 조건
스킬은 알파벳 대문자로 표기하며, 모든 문자열은 알파벳 대문자로만 이루어져 있습니다.
스킬 순서와 스킬트리는 문자열로 표기합니다.
예를 들어, C → B → D 라면 CBD로 표기합니다
선행 스킬 순서 skill의 길이는 1 이상 26 이하이며, 스킬은 중복해 주어지지 않습니다.
skill_trees는 길이 1 이상 20 이하인 배열입니다.
skill_trees의 원소는 스킬을 나타내는 문자열입니다.
skill_trees의 원소는 길이가 2 이상 26 이하인 문자열이며, 스킬이 중복해 주어지지 않습니다.
입출력 예
skill	skill_trees	return
"CBD"	["BACDE", "CBADF", "AECB", "BDA"]	2
입출력 예 설명
BACDE: B 스킬을 배우기 전에 C 스킬을 먼저 배워야 합니다. 불가능한 스킬트립니다.
CBADF: 가능한 스킬트리입니다.
AECB: 가능한 스킬트리입니다.
BDA: B 스킬을 배우기 전에 C 스킬을 먼저 배워야 합니다. 불가능한 스킬트리입니다.

 */
namespace _00.AlgorithmTest
{
    class Quize2_스킬트리
    {
        public int solution(string skill, string[] skill_trees)
        {
            int answer = skill_trees.Length;
            string strTmp = "";            
            
            /*
            문자열의 위치값을 가져와서 순서가 바뀌면 오류 
            CBD -> 123으로 변경 문자열의 위치값으로
            BACDE 2A13E....영문제거하면 213 -> 순서가 틀림 오류
            */
            foreach (var item in skill_trees)
            {
                // Console.WriteLine(item);

                int iPos = -1;
                for (int i = 0; i < skill.Length; i++)
                {
                    strTmp = skill.Substring(i, 1);

                    //첫번째 스킬이 없으면 무조건 오류임
                    if (item.IndexOf(strTmp) < 0)
                    {
                        if (i == 0)
                        {
                            answer--;
                            break;
                        }
                        continue;
                    }                       

                    // 위치값이 없으면 값을 넣는다.
                    if (iPos < 0)
                    {
                        iPos = item.IndexOf(strTmp);
                    }                        
                    else
                    {
                        if (iPos > item.IndexOf(strTmp))
                        {                            
                            answer--;
                            break;
                        }
                        iPos = item.IndexOf(strTmp);
                    }
                }                
            }

            return answer;
        }

        public void Answer()
        {
            int res = solution("CBD", new string[] { "BACDE", "CBADF", "AECB", "BDA" });
            //int res = solution("CBD", new string[] { "BDA" });
            //int res = solution("CBD", new string[] { "AECB" });

            Console.Write(res);
        }
    }
}
