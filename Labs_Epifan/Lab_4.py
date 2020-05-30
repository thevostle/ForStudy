def AddFileToText(file_name):
    file = open(file_name, 'r')
    file_result = open("text_result.txt", 'a')
    file_result.write(file.read())
    file_result.close()
    file.close()

if __name__ == '__main__':    
    AddFileToText("t1.txt")
    AddFileToText("t2.txt")
    AddFileToText("t3.txt")
    input()
