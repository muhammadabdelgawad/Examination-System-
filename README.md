# Examination System

This C# console application allows instructors to create and administer exams, and students to take them.  The system supports different exam types (Final and Practical) with multiple-choice and true/false questions.

## Features and Functionality

*   **Exam Creation:**
    *   Instructors can choose between two exam types: `FinalExam` and `PracticalExam`.
    *   Instructors define exam time limits and the number of questions.
    *   The system supports two question types: `MCQQuestion` (Multiple Choice) and `TFQuestion` (True/False).  For Final exams, instructors can choose the type of each question. Practical exams only support MCQ questions.
    *   Instructors input the question body, marks, and answer choices.
    *   Instructors specify the correct answer for each question.

*   **Exam Taking:**
    *   Students are presented with questions and their answer choices.
    *   Students input the ID of their chosen answer.
    *   The system automatically grades the exam based on the correct answers.
    *   The taken time to complete the exam will be printed when the user finishes the exam.

*   **Question Types:**
    *   `MCQQuestion`:  Each question has a body, marks, and 3 answer choices.
    *   `TFQuestion`: Each question has a body, marks and two fixed answer choices "True" and "False".

## Technology Stack

*   C# (.NET 6.0)
*   Console Application

## Prerequisites

*   .NET 6.0 SDK or later installed.  You can download it from the official [.NET website](https://dotnet.microsoft.com/download).

## Installation Instructions

1.  Clone the repository:

    ```bash
    git clone https://github.com/muhammadabdelgawad/Examination-System-.git
    ```

2.  Navigate to the project directory:

    ```bash
    cd Examination-System-/ExaminationSystem\ Solution/ExaminationSystem
    ```

## Usage Guide

1.  Build the project:

    ```bash
    dotnet build
    ```

2.  Run the application:

    ```bash
    dotnet run
    ```

3.  Follow the on-screen prompts to:

    *   Create a subject.
    *   Select the exam type (1 for Practical, 2 for Final).
    *   Enter the exam time (30-180 minutes).
    *   Enter the number of questions.
    *   Input the question details (body, marks, answer choices, correct answer). For final exams, the user is prompted to choose MCQ or True/False question types.
    *   When prompted, start the exam by entering 'Y' or 'y'.
    *   Answer the questions by entering the corresponding answer ID.

    Example Interaction:

    ```
    enter 1 for practical exam or 2 for final exam:
    1
    enter time of exam (30 to 180 min):
    60
    enter number of questions:
    2
    MCQ Question
    Please enter Body of Question:
    What is the capital of France?
    Please enter Marks of Question:
    10
    Please enter Answers of Question:
    Enter answer number 1 :
    Paris
    Enter answer number 2 :
    London
    Enter answer number 3 :
    Berlin
    please enter id of right answer
    1

    MCQ Question
    Please enter Body of Question:
    What is 2 + 2?
    Please enter Marks of Question:
    5
    Please enter Answers of Question:
    Enter answer number 1 :
    3
    Enter answer number 2 :
    4
    Enter answer number 3 :
    5
    please enter id of right answer
    2

    Do you want to start the Exam (Y | N):
    y
    MCQ Question         Marks:10
    --------
    What is the capital of France?
    1 - Paris
    2 - London
    3 - Berlin
    ---------------------------
    enter number of you answer:
    1
    -----------------

    MCQ Question         Marks:5
    --------
    What is 2 + 2?
    1 - 3
    2 - 4
    3 - 5
    ---------------------------
    enter number of you answer:
    2
    -----------------
    righ answers:
    right answer of question 1 : Paris
    right answer of question 2 : 4
    taken time : 00:00:03.4511105
    ```

## Documentation

This project is a console application and doesn't expose an external API. The core logic is within the classes located in `ExaminationSystem Solution/ExaminationSystem/`.

*   `Answer.cs`: Represents an answer to a question.
*   `Exam.cs`: Abstract base class for exams, defining common properties like time and number of questions, and abstract methods for showing the exam and creating the list of questions.
*   `FinalExam.cs`:  Represents a final exam, inheriting from `Exam`.  Allows for both MCQ and True/False questions.
*   `MCQQuestion.cs`: Represents a multiple-choice question, inheriting from `Question`.
*   `PracticalExam.cs`: Represents a practical exam, inheriting from `Exam`. Uses only MCQ questions.
*   `Program.cs`: Contains the main entry point of the application.
*   `Question.cs`: Abstract base class for questions, defining common properties like marks, body, answer list, and the correct answer.
*   `Subject.cs`: Represents a subject, and holds the logic for creating the exam.
*   `TFQuestion.cs`: Represents a true/false question, inheriting from `Question`.

## Contributing Guidelines

Contributions are welcome!  To contribute to this project:

1.  Fork the repository.
2.  Create a new branch for your feature or bug fix.
3.  Make your changes.
4.  Commit your changes with descriptive commit messages.
5.  Push your branch to your forked repository.
6.  Create a pull request to the `main` branch of the original repository.

## License Information

No license has been specified for this project. All rights are reserved by the author.
