using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> listOfPieces = new Dictionary<string, Piece>();

            for (int i = 1; i <= numberOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split('|');
                string pieceName = pieceInfo[0];
                string pieceComposer = pieceInfo[1];
                string pieceKey = pieceInfo[2];

                listOfPieces.Add(pieceName, new Piece(pieceName, pieceComposer, pieceKey));
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split('|');

                if (command[0] == "Stop")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    string currentPieceName = command[1];
                    string currentPieceComposer = command[2];
                    string currentPieceKey = command[3];

                    if (listOfPieces.ContainsKey(currentPieceName))
                    {
                        Console.WriteLine($"{currentPieceName} is already in the collection!");
                    }
                    else
                    {
                        listOfPieces.Add(currentPieceName, new Piece(currentPieceName, currentPieceComposer, currentPieceKey));
                        Console.WriteLine($"{currentPieceName} by {currentPieceComposer} in {currentPieceKey} added to the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string currentPieceName = command[1];
                    if (listOfPieces.ContainsKey(currentPieceName))
                    {
                        listOfPieces.Remove(currentPieceName);
                        Console.WriteLine($"Successfully removed {currentPieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPieceName} does not exist in the collection.");
                    }
                }
                else if(command[0] == "ChangeKey")
                {
                    string currentPieceName = command[1];
                    string currentPieceKey = command[2];

                    if (listOfPieces.ContainsKey(currentPieceName))
                    {
                        string currentPieceComposer = listOfPieces[currentPieceName].Composer;
                        listOfPieces.Remove(currentPieceName);
                        listOfPieces.Add(currentPieceName, new Piece(currentPieceName, currentPieceComposer, currentPieceKey));
                        Console.WriteLine($"Changed the key of {currentPieceName} to {currentPieceKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPieceName} does not exist in the collection.");
                    }
                }
            }

            listOfPieces.ToList().ForEach(p =>
                Console.WriteLine($"{p.Key} -> Composer: {p.Value.Composer}, Key: {p.Value.Key}"));
        }
    }

    class Piece
    {
        public Piece(string name, string composer,  string key)
        {
            Name= name;
            Composer= composer;
            Key= key;
        }
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
