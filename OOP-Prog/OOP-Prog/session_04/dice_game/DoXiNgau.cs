using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Unicode;

namespace OOP_Prog.session_04.dice_game
{
    internal class DoXiNgau
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            GameEngine();
        }

        /// <summary>
        /// Gieo cap xuc xac cho nguoi choi 
        /// Nguoi dung se doan nho (1-5) hay lon (7-10), so 6 se duoc tinh la dat biet
        /// neu doan dung nho hoac lon thi duoc tra tien bang so tien dat cuoc, nguoc lai thi mat tien dat cuoc
        /// neu doan dung so 6 thi duoc tra tien bang 3 lan so tien dat cuoc
        /// Luc khoi dau, nguoi choi se co 1000USD, nguoi choi se dat cuoc 100USD cho moi lan choi
        /// Choi cho den khi nguoi choi het tien hoac nguoi choi muon dung choi
        /// Sau khi nguoi choi het tien hoac muon dung choi, hien thi tong so lan choi, tong so lan doan dung, tong so lan doan sai, tong so lan doan dung so 6
        /// </summary>
        static void GameEngine()
        {
            int BUDGET = 1000; //TIỀN HIỆN CÓ
            int count = 0; //dem so lan choi
            int countCorrect = 0; //dem so lan doan dung/sai
            int countWrong = 0; //dem so lan doan sai
            int countNine = 0; //dem so lan doan dung nut 9
            HeartOfDice pod =new HeartOfDice();

            Console.WriteLine("WELCOME TO THE TAI XIU GAME");
            Console.WriteLine("-------------------------");
            do
            {
                //1. Gieo cap xuc xac
                pod.Roll();
                count++; //moi vong lap la 1 lan choi
                //2. Hoi nguoi dung doan nho hay lon
                Console.Write("Bạn đoán xỉu (3-10) hay tài (11-18) hay nút 9 <xiu/tai/9>? ");
                string guess = (Console.ReadLine() ?? "").Trim().ToLower();
                while (guess != "tai" && guess != "xiopu" && guess != "9")
                {
                    Console.Write("Vui lòng nhập tai, xiu hoặc 9: ");
                    guess = (Console.ReadLine() ?? "").Trim().ToLower();
                }
                //In ra kết quả gieo xúc xắc
                Console.WriteLine($"Kết quả gieo xúc xắc:{pod} - {pod.GetPoints()}");
                
                //3. Kiem tra ket qua doan cua nguoi dung
                bool isCorrect = false;//giả sử người chơi đoán sai
                switch (guess)
                {
                    case "xiu": // đoán xỉu = nhỏ
                        isCorrect = pod.GetPoints() >= 3 && pod.GetPoints() <= 10;
                        break;
                    case "tai": // đoán tài = lớn
                        isCorrect = pod.GetPoints() >= 11 && pod.GetPoints() <= 18;
                        break;
                    case "9": // đoán nút 9
                        isCorrect = pod.GetPoints() == 9;
                        break;
                }

                if (isCorrect)
                {
                    Console.WriteLine("Chúc mừng! Bạn đoán đúng.");
                    countCorrect++;
                    if(guess == "9")
                    {
                        Console.WriteLine("bạn đoán đúng nút 9");
                        countNine++;
                        BUDGET += 300; //đoán đúng nút 9, cộng 3 lần tiền cược
                    }
                    else
                    {
                        BUDGET += 100; //đoán đúng xỉu hoặc tài, cộng 1 lần tiền cược
                    }
                }
                else
                {
                    Console.WriteLine("Rất tiếc! Bạn đoán sai.");
                    countWrong++;
                    BUDGET -= 100; //đoán sai, trừ 1 lần tiền cược
                }
                //xong 1 lượt chơi
                Console.WriteLine($"Số tiền trong tài khoản: {BUDGET}");
                Console.WriteLine("--------------------------");
                //nếu không đủ tiền chơi tiếp thì dừng
                if (BUDGET < 100)
                {
                    Console.WriteLine("Bạn không đủ tiền để chơi tiếp. Kết thúc trò chơi.");
                    break;
                }

                //4.  hỏi người chơi có muốn tiếp tục chơi hay không
                Console.Write("Bạn có dám tiếp tục chơi? (y/n): ");
                string continueGame = (Console.ReadLine() ?? "").Trim().ToLower();
                if (continueGame != "y")
                {
                    break;
                }
            } while (true);

            //5. thong ke ket qua choi
            Console.WriteLine($"Bạn đã chơi {count} lần.");
            Console.WriteLine($"Bạn đoán đúng {countCorrect} lần.");
            Console.WriteLine($"Bạn đoán sai {countWrong} lần.");
            Console.WriteLine($"Bạn đoán đúng nút 9 {countNine} lần.");
            Console.WriteLine($"Số tiền trong tài khoản: {BUDGET}");

            Console.WriteLine("\n Bye, Lo kiếm tiền rồi chơi tiếp nhé.");

        }
    }
}
