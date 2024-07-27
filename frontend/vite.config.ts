import { defineConfig } from "vitest/config"
import react from "@vitejs/plugin-react"
import { resolve, dirname } from "node:path";
import path from 'path';

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react()],
  server: {
    open: true,
  },
  resolve: {
    alias: {
        '@': path.resolve(__dirname, './src'),
    },
  },
  base: "/",
  test: {
    globals: true,
    environment: "jsdom",
    setupFiles: "src/setupTests",
    mockReset: true,
  },
})
