using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace QuanLyCLB.BaiViet
{
    public class TextBoxHistory
    {
        private LinkedList<HistoryEntry> history = new LinkedList<HistoryEntry>();
        private LinkedListNode<HistoryEntry> historyIter;
        private Timer delayPushTimer;
        private HistoryEntry delayPushEntry;
        public const int HistorySize = 50;

        public TextBoxHistory()
        {
            delayPushTimer = new Timer()
            {
                Interval = 1000
            };
            delayPushTimer.Tick += DelayPushTimer_Tick;
        }

        public HistoryEntry Undo()
        {
            delayPushTimer.Stop();
            if (historyIter.Previous != null)
            {
                historyIter = historyIter.Previous;
                return historyIter.Value;
            }
            return null;
        }

        public HistoryEntry Redo()
        {
            delayPushTimer.Stop();
            if (historyIter.Next != null)
            {
                historyIter = historyIter.Next;
                return historyIter.Value;
            }
            return null;
        }

        public void Push(HistoryEntry text)
        {
            delayPushTimer.Stop();
            while (historyIter?.Next != null) history.RemoveLast();
            for (int i = HistorySize; i < history.Count; i++) history.RemoveFirst();
            historyIter = history.AddLast(text);
        }

        public void DelayPush(HistoryEntry entry)
        {
            delayPushEntry = entry;
            delayPushTimer.Stop();
            delayPushTimer.Start();
        }

        private void DelayPushTimer_Tick(object sender, System.EventArgs e)
        {
            Push(delayPushEntry);
        }

        public class HistoryEntry
        {
            public string Text { get; }
            public int SelectionStart { get; }
            public int SelectionLength { get; }

            public HistoryEntry(string text, int selectionStart, int selectionLength)
            {
                Text = text;
                SelectionStart = selectionStart;
                SelectionLength = selectionLength;
            }
        }
    }
}
