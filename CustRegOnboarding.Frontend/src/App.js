import "./App.css";
import SignatureCanvas from "react-signature-canvas";
import axios from "axios";
import { useRef, useState } from "react";

export default function App() {
  const sigPad = useRef();
  const [form, setForm] = useState({});

  const submit = async () => {
    if (!sigPad.current) return;

    const signature = sigPad.current
      .getCanvas()
      .toDataURL();

    await axios.post("https://localhost:44364/api/customers", {
      ...form,
      signature
    });

    alert("Customer registered!");
  };

  return (
    <div className="container">
      <h2 className="title">Customer Onboarding</h2>

      <input
        className="input"
        placeholder="First Name"
        onChange={e => setForm({ ...form, firstName: e.target.value })}
      />

      <input
        className="input"
        placeholder="Last Name"
        onChange={e => setForm({ ...form, lastName: e.target.value })}
      />

      <input
        className="input"
        placeholder="Email"
        onChange={e => setForm({ ...form, email: e.target.value })}
      />

      <input
        className="input"
        placeholder="Phone Number"
        onChange={e => setForm({ ...form, phoneNumber: e.target.value })}
      />

      <p>Signature:</p>

      <SignatureCanvas
        ref={sigPad}
        onEnd={() => console.log("signed")}
        canvasProps={{
          width: 350,
          height: 120,
          className: "signature"
        }}
      />

      <button className="button" onClick={submit}>
        Submit
      </button>
    </div>
  );
}