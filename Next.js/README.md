# Next.js React Components Demo

Proyek ini berisi beberapa komponen React yang dibuat dengan Next.js.

## Komponen yang Tersedia

1. **Welcome Component** - Menampilkan h1 dengan teks "Welcome nama Diwa"
2. **Counter Component** - Counter dengan state yang bisa menambah dan mengurangi nilai
3. **UserList Component** - Menampilkan list array of objects (user dengan nama dan umur)
4. **InputName Component** - Input field yang menampilkan teks yang diketik di dalam paragraph

## Cara Menjalankan

1. Install dependencies:
```bash
npm install
```

2. Jalankan development server:
```bash
npm run dev
```

3. Buka browser di `http://localhost:3000`

## Struktur Project

```
Next.js/
├── app/
│   ├── layout.tsx      # Root layout
│   ├── page.tsx        # Halaman utama
│   └── globals.css     # Global styles
├── components/
│   ├── Welcome.tsx     # Komponen Welcome
│   ├── Counter.tsx     # Komponen Counter
│   ├── UserList.tsx    # Komponen UserList
│   └── InputName.tsx   # Komponen InputName
├── package.json
├── tsconfig.json
└── next.config.js
```

