﻿// <auto-generated />
using System;
using JamesAmos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JamesAmos.Migrations
{
    [DbContext(typeof(JamesAmosDbContext))]
    [Migration("20190615181139_initia")]
    partial class initia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JamesAmos.Models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Start");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("JamesAmos.Models.DailyPrayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Book");

                    b.Property<string>("Chapter");

                    b.Property<string>("Number");

                    b.Property<string>("Verse");

                    b.HasKey("ID");

                    b.ToTable("DailyPrayer");
                });

            modelBuilder.Entity("JamesAmos.Models.HomePage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardOneImageUrl");

                    b.Property<string>("CardOneText");

                    b.Property<string>("CardOneTitle");

                    b.Property<string>("CardThreeImageUrl");

                    b.Property<string>("CardThreeText");

                    b.Property<string>("CardThreeTitle");

                    b.Property<string>("CardTwoImageUrl");

                    b.Property<string>("CommitText1");

                    b.Property<string>("CommitText2");

                    b.Property<string>("CommitText3");

                    b.Property<string>("CommitTitle1");

                    b.Property<string>("CommitTitle2");

                    b.Property<string>("CommitTitle3");

                    b.Property<string>("CommitmentHeader");

                    b.Property<int?>("DailyVerseID");

                    b.Property<string>("HeaderImageUrl");

                    b.Property<string>("HeaderSubTitle");

                    b.Property<string>("HeaderTitle");

                    b.Property<string>("WhyText1");

                    b.Property<string>("WhyTitle1");

                    b.HasKey("ID");

                    b.HasIndex("DailyVerseID");

                    b.ToTable("HomePage");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CardOneImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/50091196_587726971687971_1220812250223214592_n.jpg?_nc_cat=111&_nc_oc=AQn8bsBbmAe5Gq7musSd3K5XzPAwNoT0xA-CXjV1gX4rQNq2D5R7lQ8dBoqevqaMNso&_nc_ht=scontent-sea1-1.xx&oh=bb2914b16af9c6f7ef887ce9e0ff30b5&oe=5D832337",
                            CardOneText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has",
                            CardOneTitle = "Stuff",
                            CardThreeImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/50091196_587726971687971_1220812250223214592_n.jpg?_nc_cat=111&_nc_oc=AQn8bsBbmAe5Gq7musSd3K5XzPAwNoT0xA-CXjV1gX4rQNq2D5R7lQ8dBoqevqaMNso&_nc_ht=scontent-sea1-1.xx&oh=bb2914b16af9c6f7ef887ce9e0ff30b5&oe=5D832337",
                            CardThreeText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has",
                            CardThreeTitle = "Stuff",
                            CardTwoImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITEhITExIVFRUVFRUVFRUWFxUVFRUVFRUWFhUVFRUYHSggGBolHRUVITEhJSkrLi4uFx8zODMsNygtLisBCgoKDg0OFxAQGy0gHx0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIALcBEwMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAEBQMGAAIHAQj/xABBEAABAwIDBQQHBgUDBAMAAAABAAIDBBEFITEGEkFRYXGBkaETIjJCUrHRBxQVYsHwM0Ny4fEjkrJzg5OiFjRT/8QAGQEAAwEBAQAAAAAAAAAAAAAAAQIDAAQF/8QAIREAAgICAgMBAQEAAAAAAAAAAAECEQMSITETQVEEYSL/2gAMAwEAAhEDEQA/AOqsowFM2AKA1wXraklc1xRepBbYwFtZCGcrz063kQNGFErQuCh9Io3XW2NqEErRy0BXt1jGrlqVsSvCsY8BXhKwrRxRASAr3eUIcsMiZAZI56xrkDNOpaeS6dISwzghnuzRDjkl0kmazCmEvKGb7QUm+o4M3hI0NY4ZooZEQzRRSBUFF070vneExqWpPVNSMrFgVSwJbNccURUEhAyzFQkjoiybCK8tkseKvFPJcArmE0tiCOCuWA4jvNCaD9C5FfJYJHIQvzWz5EM96Zk4hIcvHNQ7JlM2RCxiOSJDGMgo/eWr2XQoKZCJFiwwlYtRrGjGBENUMakusTN7ryyjutgUDG5WhK9JUTnhEBtde3Q7pgo3VY5omDF5dL31vVQPrkaNQ1LwoJJQlbqwqF8zjomURWHS1gCDlxHqoDQSPRdPgBOqqor2ScmAPrCU4w5xsEXTYG0cEeyjDUXXoCsFmcbJXKHXTyQBBzOalaGQHchT0DLm6EmlF9U1oGZJV2MwwsyQ0zCl2N4m5h3dOSWQbS8HZ9qV5Y3R0R/JkcdkNp3OCWzzDimtHK+UAiLI8TkO6+qjkwsvuZHMaOG7cnvJsEb+CKFdlcnkapY8DkkbvBoAOm9lfuRVNS07ZvWJcBawytcnK/NWOSvaBp2D+yXh9j1JejnWI4TIw+s3LmM15QzCPO6b47tXuEhrQ09RY+apOIY26YPuAHAFzXAWOXA21UN47Ujol+fJpsXqlxVruKJMl1x7D8YlDr8FeMIxwOAuVZnLF2WgArfeIUFLVNKObYpdRtiFtQpmVAWj6a6HfAQhyhuGMhKFiVb7li2xtSyNKxz1X5sfA0S6XHZHeyCOq3YmpbXVAHFRurW81Uo55XalFxsPEo0zUh5LiIsgJMQJOSjZEpI6Fx0CdRFbIJKhxUJe48U4bhLiERT4OBqnpCbCOGFxPFMYcLcU9gpWt0CJaAjQHITwYPzR8OGtHBGF4HFDTYgxvFHhC8sIbTtC9JaEmmxUnQIZ1U88UN0HRjuWsAQM2I8kuc5RF6VzGUETzVZKBmmPNeSyoOSVI2NVBtDHvvA1VrhhDRmVWcFkDA6Q8Mh3rSu2hF7AreSMexlhlPlDvE6OKX2+HI2SSKWjicd2Jri0i5PrEHW2fH6hAPxy4Of7sq7S1ZLi1oJzLja5JcTe/wAh2BTeSLdo6I45xjTbo6f+KNLcvDRVLaLal7AWsYGn82vaB+qRz409gsQR/UCPmkmLYr6QWdmPMdQVpZG+mHHjjF21ZYMFr3F28918796aV2K9VzinnlYbtu9vT2h3cUY3Gw7I5cwbg+CG7SofVN2h5iWNRObuytDx11HYdR3JC+jjeHGB9yf5bvatx3T73Zr2pdicjTmCgWuIzvayCV8jSfGozhoOiZ0uHkZhbYPUGUZ+0LXPPt65Kw01KnSb5OKf+XRFQbwTuCqIQwhAUjWp0TUxrBVgooEFV5zSNFLBXEaojjowheoFuIBYhSNbA3Uo5LeOi6KzR4W0cfAIiOiaOFzzOadIVzK9T4eToExp8J5pwGgLC8LCbA8NA1vBTBoCHqMQjb7TwOl7nwSqr2hA9hhd1OQQckuwqMpD/eCgnqmt1ICrEmJTP1cGjkPqoDHfUk9qV5V6HWF+x/LjbB7PrdigfjDzoLJU1imYEvkbG8cUEuqHHUleBRgr0PWDRKFhKjL1G6VYUle9DSyqKapCT1+KNbxRMGVNUl0uItHFVnFMf1sUsw19RVzNigYXuJvyAA1c46AJlEVs63HA6SnO4LnXJU+pp6nf3GwuzNrn1QOpPJdIwLCXxQtbI9u9YX3cwO9TSUMbRvOefIJMmFSdnTg/TpHViLB9moWNBlvK/jcndvyDRqO1MKusjp4zusaw/C0AdhNu9A/j0QJEbwSCRY8xnkVWcZxd0ri0ndd8JyJ7OY7Em6iuEOsblK5dDClxkvJDrWJ0Ofaoq/Z6lkz3TG48WZD/AG+ykdI1wcOQTCprjb6rWmhmuRcNl3xOuxwkb09V3+0/oVpXUVO4f6jCHcDoR3omPFnNOefADqeCBr8ZY8lsjd4aXGRHYUApFUractcdw7w5HXxW0FM420z6oyqoi3143b7OPxNH5hxHUeSCDSMxwORTLoRumXDZmKNgLSfXJ7stAFZLWXOKesPYQrXguO71mP1+JPF1wzny43LlD1t0TBGsYwWvqp2vsnZzUTehBCWVtNbNNY5Fk8e8FiiZX81iJfTkErFqH2L65wCV1mPwRm2/c8m2cqLU18sv8R7ndL2HgMlE1o5fu91F5vhSP5/rLZNtO538OMDq438h9UDPXSv9qQ9gyHgEuhKnOYtzSOcmOscV0jenZlnzUwCjhbYKZiCCzYNUoC0at7ois9utgVG56jfMAiAILlE6WyCmrQNTZI8S2ijZf1kyFZYpKsBLa3GWNGqoWJbWOdcNSGfEHv1cqKDJuSLlie1AzAKrVZiz38bJUXrUyJ1ERyZJI4nVdT+yOBscEk/vSSbl+TWDTxJXJ9Vf9iI62KJx+7Sugcd4OAFwbahpILgeiE7rgfEltydNqcUztdK9pcQJhsDmSPL/AAqvPtHY2ML/AA3T4FY7G/Siwgkd2Bv1XPKcujujiSaaElMXl2lhmb6cv7Keqs4WdnbQ8j0KZQ4VPK47jAzK5L3Z2/pb281pPs5LawmjJ5bh+e8gla6NJ89iWOvlj0dvt5O17nIhmPRnJwLT1+qjqsAqx7rD2OP6hKaiinYfWid3WPHotqDYsDpmuF2OSmppygoJ2g8WHw8QmLaptsyCOY+iHKGtMigYWu1PcharJ1hoc7dqONXEBrc9maUzPLru6/4TrsSdG5dpzU0dSRYjVDMfzWOCIhdNmtpzH6rgHNOoPdorxHXwusd0WIBBF+K4pHIQbqz4PiBMIF3eqS32rZHMfNPCVcEssE+TpTamE/5REb4ra+a53DiL+b/94TCLFH2t69/+oFSyGpcSIeaxU/8AEnfm/wDIFi1moFa9ERoKNyLhK4T0Q2AHPP8AsimBBxuRLZERGEhbhyGMijdUIihvpFq6oSPEMYjjF3vA71UcU251EQv1KeMW+gNpdl7q8Ua3VwCq+L7ZRsuGm5VBrcXllJLnHPgEvLlaOL6Rll+FhxDaaaS+dglD5y7UkoYOut1RJIlbZvvLPSLVrSURHTogojbcqdkCljiRTWIGPcOjZ6SPf9nfZvf07wv5L6Kw6oaW2FgMgOWmS+dRDddM2IxsujELz67B6pJ9tuniEsm1yWx07iy045so2Y7zTY9PkQldDgU1PfIPbfKws4eORTCTFXtNrrzFccLInEZu4KTcHydEfIuOwaeWzHWyJJByzble3kqyah7b9qiqMUe/o4AXPPt5qFuIub7bA4c25HwOSi5Oy2qSodsrjYXSyrrGk5jJetxWAixJb0LT8xcIeodE7RzfEI7GUUAVbo+DUrlAPu+SbSQg2zuod3dJsLjismFoVzUQ3SQLHW3BCNNk5xCdobYanh2pK4FOmSmknweuaCtbWXhPArQlESz0plgkmUgy1ac+8JU4o7A3eu/+kdeKKFl0OLgcGqX0g/J5qHjr5LC/LU+CYiemb+nwWKIu6nwWLGG7JEUyYDuSZs1l4/EhpvDxFh+81zUdllj9KOa2+9AKj1O08cY3WkyEfU+8Ugr9oJpci7dbyb+pVI45MnLJFHQsT2niiBu655DMqpYntfK+4j9VpyBOqq28surRxJdkZZWyeeoc83c4k9SolqSvWtuqkuzwleBqnhgLjYAk8hmfAJ3QbL1UnsU8h6lpaPF1kLNr9EDGIlkKveH/AGa1b7b25GOp3j4D6qzYd9lsQsZpXP6D1R9fNawHKIISSA0EnkBc+CtGDbD1k9juejbzfr4LsGE7OU1P/ChaOtrnvKcsFtAsK2UPBvsyhYAZXF58B4BWWDZSkYLCJngE6sV7uI0Cyv1Gx9G8fwmjqBY+SU1n2ft1ieR25/3V4axbaLUFMqrsOYIg27nPaPacbk21ukFVO1wLQcxw1PeNVb8XhDbvbqdfqqviDY3EO3RvD3hkfJcuRcno4pJq0V10LQTck68D2oeeoa3Ldce76o6vqQ11iAdONihfTNJPAXvn2KRZoU1NU/3YvE2+SAfPLxDR4lWp24RwQFRum+iItWI2vlHFp7iP1Q1XNKPaFhzBTSTdCirpGiM3PA+adAkuBL6bmtvSIdrl6SqUc1k5ctXIfeW/plqNZOEZgh9d9j7o07UnfP1TDZ9/rP5WHzWoDY/J7fFaOd+7qCWZv7uoXzD9hGiZOXfu6xDh/wC7LETCavxzeybfv08EpnqXO1PdoPBD3WbydQSBKbZvdZdRkr0JhQmjpnyvDI2lzjoB9TkB1KuOG/ZhXSAF3oogebt93gwEearDY9xpaNT7R/TsUtDWzRZxySR/9N7mf8SpufwoofTo1B9kTB/GqXu6RsDPN28VZ8P+z7Do/wCR6Q85CX+RNvJc4w77QcRiIHpy8fDI1rx42DvNWej+16UD/Upo3kalrnM8jvIbL2Bxl6Oh0eGQxi0cLGD8rWj5BG+itwVJg+1qlNt+mmb/AEljx5kJhD9puHE5+mZ2xg/8SUylEm4yLSIlsIkgj+0PDSf4zh2xSfRTx7dYaT/9kDta8fMJto/RdJfB42MLeygocTp5heKZj/6XAnwRDjZMmK0zYBe3Q5qAoH1Y5961moO31q5/7/uk8mIjn59FB9+e42Y1xPYTbPjkhsgqLG0zmkHNVvFcHhdc23b8Wkt8eCZChnfraPhn9B++xTNwFmr3ud0GQ+pStX6HjLX2cxxjD2j2ZSSNA4AnsuLJVBhde/JlO4t+L2W+LrArtkOGws9iNoPO13eJzU7mJPD9KP8AS/RxN+xldxLWdAST+iEm2Urm/wAwHuXcnRjldQSUjTqAj40Dzs4PLgVcOI7gEFNgNSfacfp9F3yXD2fDf980DNhrPhA8z5ra0by2cLOBy8/JZ+DScXDwXZJ8BaTe1/JBS7PNzuOOnT99EGmbZHKPwZ/xHwWHBHfEfJdJl2e6HuQ82BEHJDkNo50/AnfH4hF0OHyxtOV7m9wRwV1bhDjlboO7os/B3cs+i1s1opb3uGoI7bhRmQroEGCvOTgLfmzR7dmYiLFuvLIrJgOX75Xi6LLgVA0lrpwHDUGVgI7QsW2QaOHhetC2DFhNlYQ9yU0EjQb3F+qEcvLLag2obRMJ69miIip3n3Se6/ySIAqRtQ8e8ew5jwKR4/6Osn8H7aZ/wC/DMg/NERUUgF/QuPUB1vGyrn3w8mf7QiocXeABYi2hY97SOdhcjySvEx/Kh+1pGrD10yXrWknJp/8AVKmbQSj+bUD/ALpd5Gy2/H3/AP7yd7QfPeS+KQfKh0+PofIfqpYom/uxSJmKOd/OafyybzPO5COirWk7roS3L22P3hnxzSvHJBWRMaRsc077btI0c0kOHeFc9mdtpbiKoO9fJsnHsd9Vzv8AEHxWbk8E5kH3SOXBFmtabFL/AKjyg0pcM7JUVJI3rgdvJV6u2lijNg50nMN06qvVmPSTwRRtyyAeRxI/RLnztjyAuRq4/ol8kmFYkXak2vhGf3V7upI+SeUO3NM4Wcx0fa3LxC5WK5+t0VHiZy3gLJllkgPFFnZqXE4pReORruwqckrjEVYzeuwljuYNlYqDaiojABtK3rk7xVI5/pKX5/h0MArL2Vew/bCCQhr7xu5Oy8Don0cjXZtcCrKSfRBxa7PXLyy2PYvEwpqWrR0QUm8vCQsYGfCFE+JG7t+qz0PNAItfTDLJailJyt9O5NRH0Q1bWxxAukcB8/BK6QysF/DBx8l7LFHG27i1rRzNgq9X7YuddsDN387sz3NSSpbNKd+V9rDV54dGjRSllS6Kxxv2Pa7aGFt/Rt9IRx9lv1Pgq3XYtUT5MJ3fhZ6jewuvfxKClxanYfV/1XcSdOWQGXzQVZic0gs07jOQA8srDtAU3JsoopBP4I8+/GOgDneYFisVZkgdc3LieZdme25WLUGyqAdVhapg3uWzWHguqyNETYuakZCiY6YmyZUmG3Iz8dErkOoCtlEpm4aDwVkpcLuQBmVYqPAo2NDpSBfgPaPS3BI8iRTxWUGHZ4vIDGuPYCsk2bAuCTccBY+J4Lo9QGkbsd2M4gcVq2hiaL2P6nv4LLIwPEjm7tmJAL7zegzugJ8Llbq39V0yoZv5ABo5DL/KjgwkG5cTl0unUhHjRy/7vJ8B8CtPSEc11mbCQbtYzeuBbJTRbH0zGb07bdG6lZzQvj+HJWSXz0U8VTukXPcdFeazZ2nvdrS0cGjO3Vyi/wDgW/nvNaPO3VZtezUxXQVRLSYSCPeb9Loj7zcXOXQqGo2TqIWSSMP+m05HQu6gIGmrJrevCXDi6ylLHfKKxn9HFLOCdCUxaxp4KqulDtJHMPI5ImnrJ2DUPHmpvE/Q6mPpIiNNFJDUualtPjrNHAtPVFw1DCciCEjTXY1pjIVl/aaCmVFWuZYxyub0vl4FJ4xcGxWjXEJb+BovtDtc9thI3eHNv0Vjosbgl0cAeRyPguWU8/VE/eG8R3hVjnkuyMsMWdZaAdCFt6IcVzKixSRmTJTbkc/mjJ8XqSLiUDuVlnRF4GvZ0F72NGZASLEdq6eO4B33cm5+ei57iGKyONpJHHpfLwCDdijGDIXKDyv0FYl7LbVbWTyXDGbg58UrmlABdLLcnhe5VXkxF7zqQOQyQ5ec/wBVJ2+yqSXQ/qcdYwWhYLn3iklVUSTOu9xJ4gZDwW0MQtcqaCMnQIdGIY6cD2R4LGxm1i7TS2fjZHGA2zNgh/Vbwy4E5A93+UTAhA5eaxayYm0EjfA6AiyxNqwbCKjw6+bvBMHU7bBoACIjiICmigRu2VpJEVPQNJCbwUHS3zXlFT5p3Tho0zKSUmPGJDTjdBaxoaeLjr3KdlI3VziVM6Ma8SttxKrCz17m2AaMvmtSwlEwU6LbCANUyaQrVgFNQBG/dRoApYwUa1pt1RchKIy5kTMmgvSSqglkP7sE+jpQPWcvN9uYAQUjOJXpMMawZneco2xuBBdmBo3grBFh+8ST3LY4a299VTf6JqJjDJKbu/hj3eGSMY2MeqGA9LBOhB6tgLLVtIG8EHINFfxLZ2CSxdE255DRJa/YeFgu0ubfkVcJWkEneySSqri71b96Kt9A67KRiGz8kejg4fmGaTOpHjP0bm56j6LpTWDV+fIKOmiZdznC54DgEUqM2c+grZGG293HVOIMXBFnNVilwiJ7r7gJOvQJLimzt5N2C4+LiAlcYyCm0SR1UZtY9yLbHfRVuLBKjfcA29uOi3E88JzDvmpPF8HUx48kHREQScLpNT7QNOTgm0E0T9HJdWuzWmQV9LxCUPGatjqe4yzSKtoDfSyZMVoWs6IulhcTopaeiubWumTIgwXe4NCYBrT4eLXce5ThrWNJNmgcSlFftTHHdsYuearlXXS1B1NuPIdyeONsSU0hziG0ETb7g3z8TsmhVqsxeSV2ZJHIeq1Q1DA3LU81FvqygkR2bPCX/EB0ssWpcsTGLvE26OhhC8WLmaOxDKOnFluxltF6sSRKMNgZdGRgBYsWZgiFyzisWJQBFKLnJOWQABYsQAzDTg6rGQNB0WLEUKwasjvotYYjZYsTADIGrepAssWLNg9iqpZcEJLLhtlixGEmgtWayYba19VPFQi26BmdSsWJtmCkGtpAxm63U6lQRNbHcAZnUrFiFmSPQwEZCyX4iYgPWbfuXixGCtmlwU7G8IjcQWC1ytafZ4+4437VixWkqRJPkLgZUxakEDqop8fBNnBeLFJRTHbBqvaUMFmNzVdq8RklN3O+ngsWKsIpE5NggGfVMTZjLePasWJmRl2kKpczdQuKxYihjTeWLFiItn//2Q==",
                            CommitText1 = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has",
                            CommitText2 = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has",
                            CommitText3 = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has",
                            CommitTitle1 = "Stuff",
                            CommitTitle2 = "Stuff",
                            CommitTitle3 = "Stuff",
                            CommitmentHeader = "My Commitments to Speaking Engagements",
                            HeaderImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/47390911_562063490920986_2973607404656132096_n.jpg?_nc_cat=108&_nc_oc=AQkZ9wGpnyFcbqD_Zd2kyQRghOeQ6g-5wPxTBLT8lTMn3SA8pmIg13uHJdNp7Clu9U4&_nc_ht=scontent-sea1-1.xx&oh=f9b138d58157e979ca4ebb6c01216d37&oe=5D841103",
                            HeaderSubTitle = "Stuff stuff stuff stuff",
                            HeaderTitle = "Amos Faith and Motivation",
                            WhyText1 = " Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has",
                            WhyTitle1 = "Why I am Passionate About Motivational Speaking?"
                        });
                });

            modelBuilder.Entity("JamesAmos.Models.Vlog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Subject");

                    b.Property<string>("VideoUrl");

                    b.HasKey("ID");

                    b.ToTable("Vlogs");
                });

            modelBuilder.Entity("JamesAmos.Models.HomePage", b =>
                {
                    b.HasOne("JamesAmos.Models.DailyPrayer", "DailyVerse")
                        .WithMany()
                        .HasForeignKey("DailyVerseID");
                });
#pragma warning restore 612, 618
        }
    }
}