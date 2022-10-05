char * longestPalindrome(char * s){
    int cur_length = 0;
    int max_length = 0;
    int max_L= 0; 
    int max_R = 0;
    for(int R = strlen(s); R>0; R--)
    {  
        for(int L = 0; L<R; L++)
        {    
            cur_length = 0;
            int left = L;
            int right = R;
            while(s[left] == s[right] && left<=right)
            {
                if(left == right)
                    cur_length++;
                else
                    cur_length += 2;

                left++;
                right--;
            }
            if(left == right || left>right)
            {
                if(cur_length>max_length)
                {
                    max_length = cur_length;
                    max_L = L;
                    max_R = R;
                }
            }
            if(max_length == strlen(s))
            {
                break;
            }
        }
        
        if(max_length == strlen(s))
        {
            break;
        }
    }
    int size = (max_R-max_L)+1;
    char* output = (char*)malloc(sizeof(char)*(size+1));
    for(int copy = 0; copy <size; copy++)
    {
        output[copy] = s[max_L + copy];
    }
    output[size] = '\0';
    return output;
}