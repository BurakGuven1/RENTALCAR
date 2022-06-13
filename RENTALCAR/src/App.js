import React, { Component }  from "react";



//render bi tane html döner.
class App extends Component {
  constructor(props){
    super(props);
    this.state = {
      users: []
    };
  }
  render(){
  return (
      <div className="container">
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat quia unde nobis magnam nulla voluptatem id quasi assumenda dicta illum, tempora iusto reprehenderit vel quod, quidem cum quae commodi est?</p>
      </div>
    );
  }
}

export default App;
