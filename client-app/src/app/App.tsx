import HomePage from "../features/home/HomePage"
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import DocumentPage from "../features/documents/DocumentPage";
import Header from "../features/home/Header";


function App() {

  return (
    <>
      <Header />
      <Route exact path='/' component={HomePage} />
      <Route exact path='/documents' component={DocumentPage} />
    </>

  )
}

export default App
