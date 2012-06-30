First some definitions for this problem: a) An ASCII character is one byte long
and the most significant bit in the byte is always '0'. b) A Kanji character is two
bytes long. The only characteristic of a Kanji character is that in its first byte the
most significant bit is '1'.
Now you are given an array of a characters (both ASCII and Kanji) and, an index
into the array. The index points to the start of some character. Now you need to
write a function to do a backspace (i.e. delete the character before the given
index).