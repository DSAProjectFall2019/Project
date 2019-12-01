using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1 {
	class QNode {
		public Node key;
		public QNode next;


		public QNode(Node key) {
			this.key = key;
			this.next = null;
		}
	}


	class Queue {
		QNode front, rear;

		public Queue() {
			this.front = this.rear = null;
		}


		public void enqueue(Node key) {


			QNode temp = new QNode(key);


			if (this.rear == null) {
				this.front = this.rear = temp;
				return;
			}


			this.rear.next = temp;
			this.rear = temp;
		}

		public QNode dequeue() {

			if (this.front == null)
				return null;



			QNode temp = this.front;
			this.front = this.front.next;


			if (this.front == null)
				this.rear = null;
			return temp;
		}
	}
}