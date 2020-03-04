﻿<!DOCTYPE html>
<html>
<head>
    <title></title>
</head>
<body>
    @Code dim myMessage = "Hello World" End Code

    <!-- Inline expression or variable -->
    <p>The value of myMessage is: @myMessage</p>

    <!-- Multi-statement block -->
    @Code
    dim greeting = "Welcome to our site!"
    dim weekDay = DateTime.Now.DayOfWeek
    dim greetingMessage = greeting & " Here in Huston it is: " & weekDay
    End Code

    <p>The greeting is: @greetingMessage</p>
</body>
</html>