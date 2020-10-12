import Singleton from "./program"

const example = Singleton.getInstance()

example.addUrl("https://mail.google.com/")
example.addUrl("https://mail.google.com/")
example.addUrl("https://mail.google.com/")
example.addUrl("http://youtube.com")
example.addUrl("http://youtube.com")
console.log("********************************")
example.print()
console.log("*******************************")
example.clearHistory()
console.log("*******************************")
example.print()