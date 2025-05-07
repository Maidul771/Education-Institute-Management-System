
# Education Institute Management System 

A modern ASP.NET Core MVC web application designed to automate and manage core academic activities of an educational institution. This system helps efficiently handle student data, course management, and exam result processing with clean architecture and reliable testing.



##  Features

-  Manage students, courses, and exam marks
-  **Layered Architecture**:  
   - Presentation Layer (ASP.NET Core MVC)  
   - Business Logic Layer (BLL) 
   - Data Access Layer (DAL)  
-  **Unit Testing** for BLL and DAL
-  Separation of concerns for better maintainability and scalability


## Technologies Used

- **Framework:** ASP.NET Core MVC (.NET 8)
- **Languages:** C#
- **Database:** SQL Server 
- **Architecture:** Layered (MVC + BLL + DAL)
- **Testing:** Unit Testing 
- **IDE:** Visual Studio 2022


 ## Project Structure
 
Education Institute Management System

- DAL/ # Data access layer
- BLL/ # Business logic layer
- Models/ # Application models
- Controllers/ # MVC controllers
- Views/ # Razor views
- wwwroot/ # Static files
- UnitTests/ # Unit test project
- Program.cs / Startup.cs
## Screenshots
![App Screenshot](https://media-hosting.imagekit.io/2efc45a8009840af/Student%20list.png?Expires=1841243711&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=OTMUhlcXAMUnXzrPAkSi-YePBetE9n~W-VwTv27SqzHpL0NnJbLwNv6tOfPYa9a3mcGszk~pqEVVSNOhZyLk7rEE-~hXOoZoxQyOkCVtjghwnKZyv3jNC0XPIuORoKe74OpIuKB4751F9fARwtytoIgTxkwKXXc9IZDLnVpkN90TN4e3ot4tbNhIS9XaJ1E94ydvqlxUS0nnuBJZqLSOZP0BjTpWc9Ju6UCwOBOzlGeaFFEARVhz-2tWUJMwZZtelE6dYRo1pU7OAFDmRMStkf9mzWYbTOIsY6E5xzNt~q~gJa1CiFR1yFzFarMwfY3Vp-XX9pZ6B9IFugqr7WtVxA__)

![App Screenshot](https://media-hosting.imagekit.io/b229821e404f48c1/Course%20list.png?Expires=1841243711&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=3FCU5lpS8UXb3CRLiyONpUsuh3pQ2U892yi4VzCa7sJoi2lwqJ7irxQc~JWDzxIfGTmh5AHnBHibKc3TQxYibNUNBqj9Xfavp1TDhX4iMHH2sUR3xDpf0ovvaVfDuALChbOIugAkRz-714uK2SszBkHW9CssgLTLMEDPT~Z1Tlz~Gy4UCNTsOnAn-nuDNS7hibohXdaN7HtcNmF6lE27c8hvvhdd7GDnQMLViYoQRvdSgRcMr1Qk8ysKG6jnn6H6qKTcoTlXgXfkCnHxO8zLwNtX0kHskA2ChtdUTdKifBvWPvTV0m7pGsGTLwWYHySqt389mltJ53N0vIlWPmFhKw__)

![App Screenshot](https://media-hosting.imagekit.io/923daab4da7c411e/Exam%20Marks.png?Expires=1841243711&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=NZnGzKV62asSAZiz68zH3n7MuFfBSDTTAL25vNd4mg2fW1U2hsr4gV-PfRBrBt0RHYrCWVUFZdj30izfN6Kw2KlrwOyJmZ8rRtvgyUeREcALQklhvPgHCFU-nMQ0FAigauvTXOWw85zP3idM9u6PeEor-IhliS~-U9eftJXoaKcvO6sM~gpU9QD7gBX9EMcSJJsh17EACU~Xz40AUnowU7M7eljcmPcOudw5tJ8AdhN1Uzn8UfK7hkyENPuRrsSKhWF79cZBOOWzwOlcOHNj5FprTDlW94Cad6cuMNRsAUZCFemWOyjvnwH6NtfG~y9v7Mtyxzvozb3696R~U2a55w__)

![App Screenshot](https://media-hosting.imagekit.io/28360cf474b648af/Create%20exam%20marks.png?Expires=1841243923&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=JWlEKhQOXT-Oh-Fgr6cS5hpi9OkkEGGz4R-zoEwNVAiCbsqOLHlmEOTmnih0NBP2YQR~0lOIoJTiLuhboOluMAJnz0u7z0lMRZ-8-rBPUNAzpWJyKSqLnxxU~qvRBOmb-VVxXBMrQoUrQ2AmXO-2zN2n6YLyURfF6Mwky86Fsn5YsiCRjCj8~s8n0ijE8PnF~7YkKd0fXHTCwzCJSimDookffpYptCvKJRZ0WDfNpMGfWGMeYJ41g3genXCoSQ965yeywoZvDda9cqrWZaSElsL7JGm7s9cNcs7JhrCfH7-Y7c1LF9vKuljr~6LsXdbWXc2-M5AuIMOEQKQbGsUqJQ__)

![App Screenshot](https://media-hosting.imagekit.io/55479c5e39dc4171/Edit%20exam%20marks.png?Expires=1841243711&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=U37RkBcSkOqu4bWNUCqr~yYbNjnr6rBOx6XVxnuw39LI9Tqvi4MJ1WnyfLE4XoVBnseXuuKPvjK8JmqeA~I1aYw0jDNF322U--pXrK8Jl0wjFy1alijExBmNhEJzCCNHt1SjHIL42xeoIW4zzbTGegzZ0ydwN0jk1in-IC2zrUDf5f1VQcC4090XoQeHT0mASozg6Ec46jXGT9hYyXNkrT5vIZwtChTD8mUhehc~rJRJMCv7yH~M99FzzfKm0YYTtfL6saq~9YpTHr2l3XRc0AcPbblHYJUz6q2320i-~ALO-aHVaGjqmWt0OONtTYTz7EmEP5exVojmdB2CvWKR3Q__)

![App Screenshot](https://media-hosting.imagekit.io/4c0030ec42144cb8/delete%20exam%20marks.png?Expires=1841243711&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=QfJvPnKdD5x28EBLiIoQXfngo43Wrt5rieGS1m5L7c8thOfU-IANUA5mr4BM1VjpDVhKBwLcWrzgiRJRIUQzW4u83QpjIfgNANukPBtySxIq~kZJmet09dGQDWbfQtDQQluV3TxoBpiwIrYeExGz7Zy3eR9Q41zyG0YdSbQHEN-MUftU4sAYmAgOdhK0dXNwICwZLzNtxLeQ3z-HngQiXJlnn3lAnGrDhmaYHKAH4KG6-VMcXT1nNxexURvuLy7A9brCU6Nq8RJq7NvmFjuldMUyjjjSuc~RYDp5Hw-Wk55Gc--l6uGnjDr74DerpDewNXAp04lcTvkMeTQRuGvVHA__)

![App Screenshot](https://media-hosting.imagekit.io/ebc4ac66b6184f68/Database.png?Expires=1841244122&Key-Pair-Id=K2ZIVPTIP2VGHC&Signature=RofOtgHk~eT2txI4MHi0TTvydDORyzSTy9Sa8lkKWQ1b4qh0Mcf6cs9fa9YxkfsHzLpJ87xUMBnUysnynDuQqCs1zOAlZP~rjS~n~5I2vG1NfPAU9aovcb-Cf~RbFMakXvpSJrofn~LLi7k1jNtYBs7QPuoAsDzmVPhwU7F7RkjrRQC29gWfONPbnzHw638J~XrUOrixcz7MnQ~gYWkPbUp~sGYMRpLgLskOSNkb5w~I2dLdJHhvkNrChx5JY3Rd9UJYGH-USeqCEI9D0v2cpDHZQvkVaMmq9CTvEpbucHZG~N9tnmzWCj1zwbVYImjw--ws-E6FsEJWW8Q71d9e6A__)

