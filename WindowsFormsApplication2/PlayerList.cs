/**
 * Project :        Matching Game
 * Class :          PlayerList
 * Author :         Chris Kane and Nick Bruno
 * Description :    A list that contains objects of type player
 */

/**
 * Project :        Matching Game
 * Class :          Player
 * Author :         Chris Kane and Nick Bruno
 * Description :    An object that contain attributes for the players
 */

/**
 * Project :        Matching Game
 * Class :          LinkedList
 * Author :         Chris Kane and Nick Bruno
 * Description :    A simple linked list class
 */

/**
 * Project :        Matching Game
 * Class :          Node
 * Author :         Chris Kane and Nick Bruno
 * Description :    A class for a node in the linked list class
 */

using System;
using System.Windows.Forms;

namespace matchingGame
{
    class PlayerList
    {
        private static LinkedList playerListNode;
        private int playerNumCounter;

        public PlayerList()
        { playerListNode = new LinkedList(); }

        public void addNewPlayer(string name)
        {
            playerListNode.Add(new Player(name));
            playerNumCounter++;
        }

        public int getPlayerNum()
        { return playerNumCounter; }

        public Player getNextPlayer()
        { return playerListNode.getNext(); }

        public Player setNextPlayer()
        { return playerListNode.changeToNext(); }

        //Store all the players in a string
        public String printAll(bool includeCurrentPlayer)
        {
            String stringy = "";

            Player current;

            int i = 0;
            if (includeCurrentPlayer)
                current = getCurrentPlayer();
            else
            {
                i = 1;
                current = setNextPlayer();
            }

            for (; i < playerNumCounter; i++)
            {
                current = getCurrentPlayer();
                stringy = stringy + current.getPlayerName() + " has " +
                    current.getPlayerScore() + " points.\n";
                current = setNextPlayer();
            }
            return stringy;
        }

        public String printCurrent()
        {
            return getCurrentPlayer().getPlayerName() + " has " +
                getCurrentPlayer().getPlayerScore() + " points.\n";
        }


        public string getPlayerName()
        { return playerListNode.getCurrent().getPlayerName(); }

        public int getPlayerScore()
        { return playerListNode.getCurrent().getPlayerScore(); }

        public void incrementPlayerScore()
        { playerListNode.getCurrent().incrementPlayerScore(); }

        public Player getCurrentPlayer()
        { return playerListNode.getCurrent(); }
    }

    class Player
    {
        private int score;
        private String name;

        public Player(string name)
        {
            score = 0;
            this.name = name;
        }

        public string getPlayerName()
        { return name; }


        public int getPlayerScore()
        { return score; }

        public void incrementPlayerScore()
        { score++; }
    }
    //source: https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
    class LinkedList
    {
        private Node head, iterator;
        private int count = 0;

        public void Add(Player data)
        {
            if (head != null)
            {
                Node temp = head;

                for (int i = 0; i < getCount() - 1; i++)
                    temp = temp.getNext();

                Node toAdd = new Node();
                toAdd.setData(data);

                temp.setNext(toAdd);
                temp.getNext();
            }
            else
            {
                Node toAdd = new Node();
                toAdd.setData(data);
                head = toAdd;
                iterator = head;
            }
            count++;
        }
        //returns next node while iterating
        public Player changeToNext()
        {
            if (iterator.getNext() == null)
                iterator = head;
            else
                iterator = iterator.getNext();
            return iterator.getData();
        }

        //returns next node without iterating
        public Player getNext()
        {
            if (iterator.getNext() != null)
                return iterator.getNext().getData();
            else
                return head.getData();
        }

        public int getCount()
        { return count; }

        public Player getCurrent()
        { return iterator.getData(); }

        protected class Node
        {
            private object next;
            private Player data;

            public Node getNext()
            { return (Node)next; }

            public Player getData()
            { return data; }

            public void setNext(Node next)
            { this.next = (object)next; }

            public void setData(Player data)
            { this.data = data; }
        }
    }
}
