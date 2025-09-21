# 🌍 Polyglot — Learn Languages with Confidence

> **Build your vocabulary.**  
> A modern language learning app powered by React, .NET 8, and MongoDB — designed for learners who want to master English or French (and more to come!).

## 🎯 Project Goal

**Polyglot** is a language-learning application designed to help users improve their English and French skills through interactive exercises, spaced repetition, and real-life context.  
The app will eventually support additional languages (Spanish, German, etc.), making it a scalable, multi-language learning platform.

This project is my first serious step into **Object-Oriented Programming (OOP)** and **Clean Architecture**, and I’m actively learning best practices in modern web development. I welcome **constructive feedback** from experienced developers to help me grow!

---

## 🛠️ Tech Stack

| Layer                | Technology                                    |
| -------------------- | --------------------------------------------- |
| **Frontend**         | React + TypeScript _(in progress)_            |
| **Backend API**      | .NET 8 (RESTful API)                          |
| **Database**         | MongoDB (NoSQL)                               |
| **Containerization** | Docker _(in progress)_                        |
| **Testing**          | xUnit / Moq (Unit Tests) _(in progress)_      |
| **Architecture**     | Clean Architecture (Layered, SOLID-compliant) |
| **Error Handling**   | Custom middleware _(in progress)_             |
| **Future**           | CI/CD, JWT Auth _(in progress)_               |

---

## 📁 Project Structure (Simplified)

```
Polyglot/
├── src/
│   ├── Polyglot.Api/               # Presentationr Layer
│   ├── Polyglot.Core/              # Domain Layer
│   ├── Polyglot.Gateway/           # Infrastructure Layer
│   └── Polyglot.Tests/             # Unit tests (xUnit) _(in progress)_
│
├── client/                        # React + TypeScript frontend _(in progress)_
│   ├── public/
│   └── src/
│       ├── components/
│       ├── services/              # API calls to .NET backend
│       └── App.tsx
│
├── docker-compose.yml             # (Coming soon)
├── README.md
└── .gitignore
```

---

## 🚀 How to Run Locally

> ⚠️ _Note: This project is still under active development. Setup may change._

### Backend (.NET 8)

```bash
cd src/Polyglot.Api
dotnet run
```

### Frontend (React + TypeScript)

```bash
cd client
npm install
npm run dev
```

> Make sure MongoDB is running locally (`mongod`) or via Docker.

### Future: Docker

I’m currently containerizing the app with Docker. Stay tuned — `docker-compose.yml` coming soon!

---

## 🤝 I Need Your Help!

As a beginner, I’m learning by doing — and I’d be incredibly grateful for your feedback on:

- ✅ **Architecture**: Is the Clean Architecture implemented correctly?
- ✅ **SOLID**: Are my classes following the principles properly?
- ✅ **Testing**: Are my unit tests meaningful? What should I test next?
- ✅ **API Design**: Are endpoints intuitive? Are responses consistent?
- ✅ **Code Quality**: Any red flags? Bad patterns? Improvements?

👉 **Open an Issue** or **start a Discussion** on GitHub — or just drop a comment on a PR!

---

## 🙏 Acknowledgments

- Thank you to the .NET and React communities for their incredible documentation and support.
- Special thanks to every developer who takes time to review beginner code — your kindness changes lives.

---

> 🌱 _“The best way to learn is to build — and to ask for help.”_  
> — Me, right now 😊

---

### 🔗 Connect with me

- GitHub: [@B3N0I7](https://github.com/B3N0I7)

---

## ✅ Next Steps (Roadmap)

- [ ] Add user authentication (JWT)
- [ ] Implement Docker containers for API + MongoDB
- [ ] Add CI/CD pipeline (GitHub Actions)
- [ ] Integrate spaced repetition algorithm
- [ ] Support for Spanish and German
- [ ] Add progress tracking & analytics

---
