class Stack:
    array = []

    current = -1

    def push(self, item):
        self.array.append(item)
        self.current += 1

    def pop(self):
        if self.current > -1:
            self.array.pop(self.current)
            self.current -= 1
        else:
            print("Стек пустой")

    def peek(self):
        if self.current > -1:
            return self.array[self.current]
        else:
            print("Стек пустой")


program = ['beGIN', '123', '211', 'end']


s = Stack()

banned = False
for word in program:
    if word.lower == 'begin':
        s.push(1)
    if word.lower == 'end':
        if len(s.array) > 0:
            s.pop()
        else:
            print("БАН")
            banned = True



if len(s.array) == 0 and not banned:
    print("Ну ты и жмых")
    
if len(s.array) > 0:
    print("БАН")

input()
