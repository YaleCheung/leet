public class Solution {
    public int MyAtoi(string str) {
            int ret = 0;
            int error = 0;
            bool has_neg_signed = false;
            bool has_pos_signed = false;
            bool started = false;
            bool ended = false;
            bool max_reached = false;
            
            foreach(var c in str) {
                if (ended)
                    break;

                if (c == '-') {
                    if (started || has_neg_signed || has_pos_signed) 
                        ended = true;

                    has_neg_signed = true;
                } else if (started || c == '+') {
                    if (has_neg_signed || has_pos_signed)
                        ended = true;

                    has_pos_signed = true;
                } 
                else if (Char.IsWhiteSpace(c)) {
                    if (started || has_neg_signed || has_pos_signed) {
                        ended = true;
                    }
                } else if (Char.IsDigit(c)) {
                    started = true;
                    if (ret > int.MaxValue / 10)
                        max_reached = true;
                    ret = ret * 10 + c - '0';
                    if (ret < 0)
                        max_reached = true;
                } else 
                    ended = true;
            }
            if (max_reached)
                return has_neg_signed ? int.MinValue : int.MaxValue;
            else return has_neg_signed ? -ret : ret;
    }
}
