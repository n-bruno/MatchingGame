/**
 * Class :          PlayerList
 * Author :         Chris Kane and Nick Bruno
 * Description :    A list that contains objects of type player
 */

/**
* Class :          Player
* Author :         Chris Kane and Nick Bruno
* Description :    An object that contain attributes for the players
*/

/**
* Class :          LinkedList
* Author :         Chris Kane and Nick Bruno
* Description :    A simple linked list class
*/

/**
* Class :          Node
* Author :         Chris Kane and Nick Bruno
* Description :    A class for a node in the linked list class
*/


using System;

namespace matchingGame
{
    class PlayerList
    {
        private static LinkedList playerListNode = new LinkedList();

        public void addNewPlayer(string name)
        {
            playerListNode.Add(new Player(name));
        }

        public Player getNextPlayer()
        {
            return playerListNode.next();

        }

        public String printAll()
        {
            String stringy = "";

            LinkedList iterator = playerListNode;

            iterator.setIteratortoHead();

            int i = 0;

            //access all elements in the list
            while (i < iterator.getCount())
            {
                stringy = stringy + iterator.getCurrent().getPlayerName() +
                    " has " + iterator.getCurrent().getPlayerScore() + " points.\n";
                i++;
                iterator.next(); //get the next person
            }
            return stringy;
        }

        public string getPlayerName()
        {
            return playerListNode.getCurrent().getPlayerName();
        }

        public int getPlayerScore()
        {
            return playerListNode.getCurrent().getPlayerScore();
        }
        public void incrementPlayerScore()
        {
            playerListNode.getCurrent().incrementPlayerScore();
        }
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
        {
            return name;

        }

        public int getPlayerScore()
        {
            return score;
        }

        public void incrementPlayerScore()
        {
            score++;
        }
    }
    //source: https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list

    class LinkedList
    {
        private Node head;
        private Node iterator;
        private int count = 0;

        public void Add(Player data)
        {
            if (head != null)
            {
                Node toAdd = new Node();
                toAdd.setData(data);
                toAdd.setNext(head);

                head = toAdd;

                iterator = head;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.setData(data);
                head = toAdd;
                iterator = head;
            }
            count ++;
        }

        public Player next()
        {
            if (iterator.getNext() == null)
                iterator = head;
            else 
                iterator = iterator.getNext();

            return iterator.getData();
        }

        public void setIteratortoHead()
        {
            iterator = head;
        }

        public int getCount()
        {
            return count;
        }

        public Player getCurrent()
        {
            return iterator.getData();
        }

        protected class Node
        {
            private Node next;
            private Player data;

            public Node getNext()
            {
                return next;
            }

            public Player getData()
            {
                return data;
            }


            public void setNext(Node next)
            {
                this.next = next;
            }

            public void setData(Player data)
            {
                this.data = data;
            }
        }
    }
}
