﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "가", "나"};
            Console.Write(Console.ReadLine());
            try
            {

                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("입력한 위치의 값은'" + array[input] + "'입니다.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("인덱스 범위를 벗어났습니다.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("숫자를 입력해주세요!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("옳게 실해되는 예외가 발생하든 실행됨");
            }

        }
    }
}
